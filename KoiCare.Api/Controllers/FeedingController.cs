﻿using KoiCare.Application.Features.Feeding;
using KoiCare.Infrastructure.Middleware;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KoiCare.Api.Controllers
{
    [Auth]
    [ApiController]
    [Route("api/[controller]")]
    public class FeedingController(IMediator mediator) : BaseController
    {
        [HttpGet("{KoiIndividualId}")]
        public async Task<ActionResult<GetFeedingSchedule.Result>> GetFeedingSchedule(int KoiIndividualId)
        {
            var query = new GetFeedingSchedule.Query { PondId = KoiIndividualId };
            var result = await mediator.Send(query);
            return CommandResult(result);
        }

        [HttpPost("create")]
        public async Task<ActionResult<CreateFeedingSchedule.Result>> CreateFeedingSchedule([FromBody] CreateFeedingSchedule.Command command)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await mediator.Send(command);
            return CommandResult(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UpdateFeedingSchedule.Result>> UpdateFeedingSchedule(int id, [FromBody] UpdateFeedingSchedule.Command command)
        {
            if (id != command.Id)
            {
                return BadRequest("ID mismatch");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await mediator.Send(command);
            return CommandResult(result);
        }

        [HttpPost("feed-calculation")]
        public async Task<ActionResult<CalculateFeedingAmount.Result>> CalculateFeedingAmount([FromBody] CalculateFeedingAmount.Command command)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await mediator.Send(command);
            return CommandResult(result);
        }

        [HttpGet("feed-calculation")]
        public async Task<ActionResult<GetFeedingCalculation.QueryResult>> CalculateFeedingAmount([FromQuery] GetFeedingCalculation.Query query)
        {
            var result = await mediator.Send(query);
            return CommandResult(result);
        }

        [HttpGet("serving-size")]
        public async Task<ActionResult<GetServingSize.Result>> GetServingSize([FromQuery] GetServingSize.Query query)
        {
            var result = await mediator.Send(query);
            return CommandResult(result);
        }
    }
}
