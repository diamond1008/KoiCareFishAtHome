﻿using KoiCare.Application.Abtractions.Authentication;
using KoiCare.Application.Abtractions.Database;
using KoiCare.Application.Abtractions.Localization;
using KoiCare.Application.Abtractions.LoggedUser;
using KoiCare.Application.Commons;
using KoiCare.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Net;

namespace KoiCare.Application.Features.Account
{
    public class LoginUser
    {
        public class Command : IRequest<CommandResult<Result>>
        {
            public required string Email { get; set; }
            public required string Password { get; set; }
        }

        public class Result
        {
            public string? AccessToken { get; set; }
            public string? RefreshToken { get; set; }
            public int RoleId { get; set; }
            public string RoleName { get; set; } = string.Empty;
            public string UserName { get; set; } = string.Empty;
            public string? Message { get; set; }
        }

        public class Handler(
            IJwtProvider jwtProvider,
            IRepository<User> userRepos,
            IAppLocalizer localizer,
            ILogger<LoginUser> logger,
            ILoggedUser loggedUser,
            IUnitOfWork unitOfWork
            ) : BaseRequestHandler<Command, CommandResult<Result>>(localizer, logger, loggedUser, unitOfWork)
        {
            private readonly IJwtProvider _jwtProvider = jwtProvider;
            private readonly IRepository<User> _userRepos = userRepos;

            public override async Task<CommandResult<Result>> Handle(Command request, CancellationToken cancellationToken)
            {
                try
                {
                    var response = await _jwtProvider.GenerateTokenAsync(request.Email, request.Password, cancellationToken);
                    if (string.IsNullOrEmpty(response?.IdToken))
                    {
                        return CommandResult<Result>.Fail(_localizer["Wrong email or password"]);
                    }

                    var user = await _userRepos.Queryable()
                        .Include(u => u.Role)
                        .FirstOrDefaultAsync(x => x.Email == request.Email, cancellationToken);
                    if (user == null)
                    {
                        return CommandResult<Result>.Fail(_localizer["User not found"]);
                    }

                    return CommandResult<Result>.Success(new Result
                    {
                        AccessToken = response!.IdToken,
                        RefreshToken = response.RefreshToken!,
                        RoleId = user.RoleId,
                        RoleName = user.Role.Name,
                        UserName = user.Username,
                        Message = _localizer["Login successfully"]
                    });
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, ex.Message);
                    return CommandResult<Result>.Fail(HttpStatusCode.InternalServerError, ex.Message);
                }
            }
        }
    }
}
