using LocalizationDemo.Data;

namespace LocalizationDemo.Services
{
    public class ResourceSource : IResourceSource
    {
        private readonly DataContext context;

        public ResourceSource(DataContext context) => this.context = context;

        public string Get(string key) => $"[{key}]";
    }
}
