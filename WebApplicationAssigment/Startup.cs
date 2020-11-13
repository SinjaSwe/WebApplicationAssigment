using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebApplicationAssigment
{
    public class Startup
    {
          public void ConfigureServices(IServiceCollection services)
        {
            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                options.Cookie.Name = ".RandomNumber.Session";
                options.IdleTimeout = TimeSpan.FromSeconds(10);
                options.Cookie.IsEssential = true;
            });
            services.AddMvc(); //IMPORTANT TO ADD MANUALLY  
            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();//IMPORTANT TO ADD MANUALLY
            app.UseStaticFiles();
            app.UseRouting();
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "tempCheck",
                pattern: "{controller=Temp}/{action=TempChecker}/{id?}");

                endpoints.MapControllerRoute(
                name: "guessGame",
                pattern: "{controller=Guess}/{action=GuessingGame}/{id?}");                

                endpoints.MapDefaultControllerRoute(); //IMPORTANT TO ADD MANUALLY
                endpoints.MapRazorPages();
            });
        }
    }
}
