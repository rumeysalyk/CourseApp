using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

namespace CourseApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();//böylece wwwroot klasörü dışarı açılır

            app.UseStaticFiles(new StaticFileOptions{

                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(),"node_modules")),
                    RequestPath = "/modules"

            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //bu userdan alınan istekleri 2 şekilde route edebiliyoruz

            //1.yol default route metodunu kullanmak
            //app.UseMvcWithDefaultRoute();

            //
            app.UseMvc(routes=>{
                routes.MapRoute(
                    name:"default",
                    template:"{controller=Home}/{action=Index}/{id?}"//burada default page Course ve actionu indexdir
                );
            });

            
        }
    }
}
