using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Mvc.Application.Services.ToDo.Accounting;
using Mvc.Application.Services.ToDo.Accounting.Impls;
using Mvc.Areas.Tests.Controllers;
using Mvc.Areas.Tests.Filters;

namespace Mvc
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddControllersWithViews(opts =>
                {
                    opts.Filters.Add(new GlobalActionFilter());
                })
                .AddRazorRuntimeCompilation()
                .ConfigureApplicationPartManager(appPartMngr =>
                    {
                        appPartMngr.ApplicationParts.Add(new AssemblyPart(typeof(TagHelpersController).Assembly));
                    }
                );
            services.AddScoped<ActionCallInfoFilter>();
            services.AddScoped<IToDoItemAccountingService, FakeInMemoryTodoItemAccountingService>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            else
            {
                app.UseExceptionHandler("/error");
            }

            app.UseStatusCodePages();
            
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    "{area:exists=Trees}/{controller=Home}/{action=Index}/{treeId?}"
                );
            });
        }
    }
}