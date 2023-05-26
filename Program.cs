using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;


namespace ContactManagementApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            IServiceCollection services = new ServiceCollection();

            Startup startup = new Startup();
            startup.ConfigureServices(services);
            IServiceProvider serviceProvider = services.BuildServiceProvider();


            var directoryOperation = serviceProvider.GetService<IDirectoryOperation>();

            directoryOperation.Entrance();


        }
    }
}