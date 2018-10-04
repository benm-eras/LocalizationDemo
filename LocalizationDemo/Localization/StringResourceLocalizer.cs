using LocalizationDemo.Services;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace LocalizationDemo.Localization
{
    public class StringResourceLocalizer : IStringLocalizer
    {
        private readonly IResourceSource resources;

        public StringResourceLocalizer(IResourceSource resources) => this.resources = resources;

        public LocalizedString this[string name] => new LocalizedString(name, this.resources.Get(name));

        public LocalizedString this[string name, params object[] arguments] => new LocalizedString(name, this.resources.Get(name));

        public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures) => throw new NotImplementedException();
        public IStringLocalizer WithCulture(CultureInfo culture) => throw new NotImplementedException();
    }
}
