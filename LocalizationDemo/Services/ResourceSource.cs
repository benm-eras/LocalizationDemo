using LocalizationDemo.Data;
using System.Linq;

namespace LocalizationDemo.Services
{
    public class ResourceSource : IResourceSource
    {
        private readonly DataContext context;
        //private readonly DataContextAccessor contextAccessor;

        public ResourceSource(DataContext context) => this.context = context;
        //public ResourceSource(DataContextAccessor contextAccessor) => this.contextAccessor = contextAccessor;

        public string Get(string key)
        {
            // get stuff from db
            //int n = this.contextAccessor.Context.Foos.Count();
            int n = this.context.Foos.Count();

            return $"[{key}-{n}]";
        }
    }
}
