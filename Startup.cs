using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ContactManagementApp
{
    public class Startup
    {
        IConfigurationRoot Configuration { get; }

        public Startup()
        {
            var builder = new ConfigurationBuilder();

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IConfigurationRoot>(Configuration);
            services.AddScoped<IDirectoryOperation, DirectoryOperation>();
            services.AddScoped<IDirectory, DirectoryService>();



        }
    }
}
