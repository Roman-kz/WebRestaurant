using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebRestaurant.Data;
using WebRestaurant.Data.interfaces;
using WebRestaurant.Data.mocks;
using WebRestaurant.Data.Models;
using WebRestaurant.Data.Repository;

namespace WebRestaurant
{
    public class Startup
    {
        private IConfigurationRoot _confSting;

        public Startup(IHostingEnvironment hostEnv)
        {
            _confSting = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }


        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confSting.GetConnectionString("DefaultConnection")));
            services.AddTransient<IALLDishes, DishesRepository>();
            services.AddTransient<IDeshesCategory, CategoryRepository>();
            //services.AddTransient<IALLDishes, MockDishes>();
            //services.AddTransient<IDeshesCategory, MockCategory>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShopDisher.GetDisher(sp));

            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
        }

       
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(router =>
            {
                router.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
                router.MapRoute(name: "categoryFilter", template: "Dishes/{action}/{category?}", defaults: new { Controller = "Dishes", action = "List" });
            });


            
           
            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                DBObjects.Initial(content);
            }


            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
