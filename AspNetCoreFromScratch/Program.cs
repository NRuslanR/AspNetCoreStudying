using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AspNetCoreFromScratch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>

            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(
                    webHostBuilder =>
                    {
                        webHostBuilder
                            .ConfigureServices(
                            (ctx, services) =>
                            {
                                services.Configure<HostOptions>(
                                    opts =>
                                    {
                                        opts.ShutdownTimeout = TimeSpan.FromSeconds(10);
                                    });
                            })
                            .ConfigureAppConfiguration(
                                (ctx, cfgBuilder) =>
                                {
                                    cfgBuilder.Sources.Clear();
                                    
                                    cfgBuilder.SetBasePath(Directory.GetCurrentDirectory());
                                    cfgBuilder.AddJsonFile($"appsettings.json");
                                    cfgBuilder.AddJsonFile("topitem.json");
                                    cfgBuilder.AddJsonFile($"appsettings.{ctx.HostingEnvironment.EnvironmentName}.json", optional: true, reloadOnChange: true);
                                    cfgBuilder.AddEnvironmentVariables(prefix: "TEST_PREFIX_");
                                    cfgBuilder.AddXmlFile("position.xml", optional: true, reloadOnChange: true);
                                    cfgBuilder.AddKeyPerFile(
                                        directoryPath: Path.Combine(
                                            Directory.GetCurrentDirectory(), "KeyPerFile"), optional: true);

                                    var keyValues = new Dictionary<string, string>();

                                    keyValues["Mem1"] = "Value1";
                                    keyValues["Mem2:SubMem2"] = "Value2";
                                        
                                    cfgBuilder.AddInMemoryCollection(
                                        keyValues);
                                    
                                    if (args != null) 
                                        cfgBuilder.AddCommandLine(args);

                                });

                        webHostBuilder.UseStartup<Startup>();
                        webHostBuilder.ConfigureLogging(
                            (ctx, logging) =>
                            {
                                logging.ClearProviders();

                                logging.AddConsole();
                                logging.AddDebug();
                            });
                    });
    }
}