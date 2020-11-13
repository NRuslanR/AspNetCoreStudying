using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Server.Kestrel.Core.Features;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Npgsql;

namespace AspNetCoreFromScratch
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        private readonly IWebHostEnvironment _env;
        
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            _env = env;
            
            Trace.AutoFlush = true;
            
            Configuration = configuration;
            
            Trace.WriteLine(
                string.Join(", ",
                from p in ((IConfigurationRoot) configuration).Providers
                let pName = p.ToString()
                select p.ToString()
                )
                );
            
            if (Configuration.GetSection("test1.json").Exists())
                Trace.WriteLine(Configuration.GetSection("test1.json").Value);
            
            if (Configuration.GetSection("test2.css").Exists())
                Trace.WriteLine(Configuration.GetSection("test2.css").Value);
            
            if (Configuration.GetSection("test3.txt").Exists())
                Trace.WriteLine(Configuration.GetSection("test3.txt").Value);
            
            if (Configuration.GetSection("Mem1").Exists())
                Trace.WriteLine(Configuration.GetSection("Mem1").Value);
            
            if (Configuration.GetSection("Mem2").Exists())
                Trace.WriteLine(Configuration.GetSection("Mem2").Value);
            
            if (Configuration.GetSection("Mem2:SubMem2").Exists())
                Trace.WriteLine(Configuration.GetSection("Mem2:SubMem2").Value);
        }
        
        public IConfiguration Configuration { get; private set; }
        
        public void ConfigureServices(IServiceCollection services)
        {
            if (_env.IsDevelopment())
            {
                Console.WriteLine("Development Environment");
            }
            
            else if (_env.IsProduction())
            {
                Console.WriteLine("Production Environment");
            }
            
            services.AddControllersWithViews();
            services.AddRouting(opts =>
            {
                opts.ConstraintMap.Add("custom", typeof(CustomConstraint));
            });
            
            /*
            Configuration.GetSection("Position").Bind(new PositionOptions(),
                binderOpts =>
                {
                    binderOpts.BindNonPublicProperties = false;
                });*/
            
            DbProviderFactories.RegisterFactory(
                "Npgsql", NpgsqlFactory.Instance
                );

            services.AddDirectoryBrowser();
            services.AddAuthentication(opts =>
            {

            });
            services.AddAuthorization();
            services.AddStylization(Configuration);
            services.PostConfigure<PositionOptions>(opts => opts.Name = "TRUN TRUN");
            //services.TryAddEnumerable(ServiceDescriptor.Singleton<IValidateOptions<PositionOptions>, PositionOptions>());
            services.Configure<PositionOptions>(Configuration.GetSection("Position"));
            services.Configure<DatabaseLoggingConfiguration>(Configuration.GetSection("Logging:Database"));
            services.AddOptions<PositionOptions>().ValidateDataAnnotations();
            services.Configure<TopItemSettings>(TopItemSettings.YEAR, Configuration.GetSection("TopItem:Year"));
            services.Configure<TopItemSettings>(TopItemSettings.MONTH, Configuration.GetSection("TopItem:Month"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app, 
            IWebHostEnvironment env,
            ILoggerFactory loggerFactory)
        {
            Trace.AutoFlush = true;

            loggerFactory.AddDatabaseLogger(Configuration);
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            else if (env.IsProduction() || env.IsStaging() || env.IsEnvironment("Staging_2"))
            {
                /*
                app.UseExceptionHandler(errorBuilder =>
                {
                    errorBuilder.Run(async ctx =>
                    {
                        var pathFeature = ctx.Features.Get<IExceptionHandlerPathFeature>();

                        await ctx.Response.WriteAsync(
                            $"<h1>At the path \"{pathFeature.Path}\" the following error occured: {pathFeature.Error.Message}</h1>");
                    });
                });*/
                app.UseExceptionHandler("/ErrorHandling/Index");
            }

            app.UseStatusCodePages();

            /*
             Static Files + Default Files + Directory Browsing (optionally)
            app.UseFileServer(
                new FileServerOptions()
                {

                });*/
            
            app.UseDefaultFiles(
                new DefaultFilesOptions()
                {
                    FileProvider = new PhysicalFileProvider(
                        Path.Combine(env.ContentRootPath, "static")),
                    RequestPath = "/my_static",
                    DefaultFileNames = new []
                    {
                        "index.html"
                    }
                });
            
            app.UseStaticFiles();

            app.UseMiddleware<LoggingMiddleware>();
         
            app.Use(
                async (ctx, next) =>
                {
                    if (ctx.Request.Path == "/terminal")
                    {
                        await ctx.Response.WriteAsync("Terminal Endpoint is executed");
                        return;
                    }

                    await next.Invoke();
                });

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            
            app.UseStaticFiles(
                new StaticFileOptions()
                {
                    FileProvider = new PhysicalFileProvider(
                        Path.Combine(env.ContentRootPath, "static")),
                    RequestPath = "/my_static",
                    OnPrepareResponse = ctx =>
                    {
                        ctx.Context.Response.Headers.Add(
                            $"Cache-Control", $"public, max-age: {60}");
                    }
                });

            app.UseDirectoryBrowser(
                new DirectoryBrowserOptions()
                {
                    FileProvider = new PhysicalFileProvider(
                        Path.Combine(env.ContentRootPath, "static/images")),
                    RequestPath = "/my_images"
                });
            
            app.UseMiddleware<ProductsLinkMiddleware>();
            
            app.UseEndpoints(
                
                endpoints =>
                {
                    endpoints.MapDefaultControllerRoute();
                    
                    endpoints.MapControllerRoute(
                        "Home",
                        "/{Controller}/{Action}/{Params?}",
                        new {Controller = "Home", Action = "Index"});

                    endpoints.MapControllerRoute(
                        "GetProduct",
                        "Products/GetProduct/{productId:int:max(200)}",
                        defaults: new { Controller = "Products", Action = "GetProduct" }
                    );
                });
        }
    }
}