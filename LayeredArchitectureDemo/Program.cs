using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using BusinessLayer;
using DataAccessLayer;
using BusinessLayer.Interfaces;
using DataAccessLayer.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace LayeredArchitectureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // set up depency injection

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();       
           
            var logger = serviceProvider.GetService<ILogger<Program>>();
            logger.LogInformation("App started");
          
            var test = serviceProvider.GetService<ILayredArcDemoBLC>();
            test.MethodOneBLC();
            logger.LogInformation("app is done with its work testing");
            
            Console.ReadKey();
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            //we will configure logging here
            services
            .AddLogging(configure => configure.AddConsole())
            .Configure<LoggerFilterOptions>(options => options.MinLevel = LogLevel.Information)
            .AddSingleton<ILayredArcDemoDLC, LayredArcDLC>()
            .AddSingleton<ILayredArcDemoBLC, LayredArcBLC>();
        }
    }
}
