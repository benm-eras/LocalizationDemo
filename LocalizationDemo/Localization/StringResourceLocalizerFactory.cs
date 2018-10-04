using LocalizationDemo.Services;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalizationDemo.Localization
{
    public class StringResourceLocalizerFactory : IStringLocalizerFactory
    {
        private readonly IResourceSource resources;

        public StringResourceLocalizerFactory(IResourceSource resources) => this.resources = resources;

        public IStringLocalizer Create(Type resourceSource) => new StringResourceLocalizer(this.resources);
        public IStringLocalizer Create(string baseName, string location) => new StringResourceLocalizer(this.resources);
    }
}
