using LocalizationDemo.Services;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace LocalizationDemo.Localization
{
    public class HtmlResourceLocalizer : IHtmlLocalizer
    {
        private readonly IResourceSource resources;

        public HtmlResourceLocalizer(IResourceSource resources) => this.resources = resources;

        public LocalizedHtmlString this[string name] => new LocalizedHtmlString(name, this.resources.Get(name));

        public LocalizedHtmlString this[string name, params object[] arguments] => new LocalizedHtmlString(name, this.resources.Get(name));

        public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures) => throw new NotImplementedException();

        public LocalizedString GetString(string name) => new LocalizedString(name, this.resources.Get(name));

        public LocalizedString GetString(string name, params object[] arguments) => new LocalizedString(name, this.resources.Get(name));

        public IHtmlLocalizer WithCulture(CultureInfo culture) => throw new NotImplementedException();
    }
}
