﻿using KoiCare.Application.Abtractions.Localization;
using KoiCare.Infrastructure.Resources;
using Microsoft.Extensions.Localization;

namespace KoiCare.Infrastructure.Dependencies.Localization
{
    public class AppLocalizer(IStringLocalizer<SharedResource> localizer) : IAppLocalizer
    {
        private readonly IStringLocalizer<SharedResource> _localizer = localizer;

        public string this[string name] => _localizer[name];

        public string this[string name, params object[] arguments] => _localizer[name, arguments];

        public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
        {
            return _localizer.GetAllStrings(includeParentCultures);
        }

        public LocalizedString GetString(string name)
        {
            return _localizer[name];
        }

        public LocalizedString GetString(string name, params object[] arguments)
        {
            return _localizer[name, arguments];
        }
    }
}
