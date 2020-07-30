using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataBase;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebApplication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScoped<TestContext, TestContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            using (var scope = 
                app.ApplicationServices.CreateScope())
            using (var context = scope.ServiceProvider.GetService<TestContext>())
            {
                context.Database.Migrate();
                if (!context.Cars.Any())
                {
                    for (int i = 0; i < 10; i++)
                    {
                        var c = new Car
                        {
                            Description = Faker.Name.FullName(),
                            Name = Faker.Name.First()
                        };
                        for (int j = 0; j < 5; j++)
                        {
                            var p = new Price
                            {
                                Value = Faker.RandomNumber.Next(0,10000)
                            };
                            c.Prices.Add(p);
                        }

                        context.Cars.Add(c);
                    }

                    context.SaveChanges();
                }
            }
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}