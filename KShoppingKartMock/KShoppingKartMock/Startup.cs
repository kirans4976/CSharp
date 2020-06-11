using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KShoppingKartMock.Data.Interfaces;
using KShoppingKartMock.Data.Mocks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace KShoppingKartMock
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(); // need to KNW whhy?(for mvc configs like route )
            // why transient
            services.AddTransient<IMobileRepository,MockMobileRepository>();
            services.AddTransient<ICategoryRepository, MockCategoryRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // for differntialting env for like displaying different error msg's
            //if (env.IsDevelopment())
            //{
            //    //app.UseDeveloperExceptionPage(); // need to KNW this why?
            //    //throw new Exception("This is a test exception");
            //    app.Run(async (context) =>
            //    {
            //        await context.Response.WriteAsync("IsDevelopment"); // wht does this do exactly?
            //    });
            //}

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});

            //if (env.IsProduction())
            //{
            //    //app.UseDeveloperExceptionPage();
            //    app.Run(async (context) =>
            //    {
            //        await context.Response.WriteAsync("ISProduction");
            //    });
            //}

            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            //app.UseSession();
            //app.UseAuthentication();
            app.UseMvcWithDefaultRoute();
        }
    }
}
