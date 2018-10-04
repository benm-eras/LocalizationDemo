using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace LocalizationDemo.Data
{
    public class DataContextAccessor
    {
        private readonly IServiceProvider services;
        private DataContext context;

        public DataContext Context => this.GetContext();

        public DataContextAccessor(IServiceProvider services) => this.services = services;

        private DataContext GetContext()
        {
            // TODO: work out how to check if the context is disposed
            if (this.context == null)
                this.context = this.services.GetService<DataContext>();

            return this.context;
        }
    }
}
