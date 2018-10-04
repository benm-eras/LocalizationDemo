using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocalizationDemo.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LocalizationDemo
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataContext>(o => o.UseInMemoryDatabase());
            
            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
                //.AddDataAnnotationsLocalization(o =>
                //{
                //    o.DataAnnotationLocalizerProvider = (type, factory) => factory.Create(typeof(Startup));
                //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider services)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRequestLocalization();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            #region Seed

            DataContext context = services.GetService<DataContext>();

            for (int f = 1; f <= 3; f++)
            {
                Foo foo = context.Foos.Include(x => x.Bars).SingleOrDefault(x => x.Id == f);

                if(foo == null)
                {
                    foo = new Foo() { Id = f };

                    for (int b = 1; b <= 3; b++)
                        foo.Bars.Add(new Bar() { Value = $"Foo {f} Bar {b}" });

                    context.Add(foo);
                }                
            }

            context.SaveChanges();

            #endregion

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}");
            });
        }
    }
}
