using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClothShop.Core.ApplicationServices;
using ClothShop.Core.ApplicationServices.Impl;
using ClothShop.Core.DomainServices;
using ClothShop.Core.Entity;
using ClothShop.Core.Entity.Enum;
using ClothShop.Infrastructure.Contexts;
using ClothShop.Infrastructure.Repositories;
using ClothShop.Infrastructure.Seeder;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ClothShop.RestApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;
            Env = env;
        }

        public IConfiguration Configuration { get; }

        public IHostingEnvironment Env { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            if (Env.IsDevelopment())
            {
                services.AddDbContext<ClothingContext>(opt => opt.UseSqlite("Data Source = G3ClothingShop.db"));
            }
            else
            {
                services.AddDbContext<ClothingContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("defaultConnection")));
            }

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddMvc().AddJsonOptions(
                options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );

            services.AddScoped<IRepository<ClothingArticle>, ClothingRepository>();
            services.AddScoped<IRepository<ClothingSize>, SizeRepository>();
            services.AddScoped<IRepository<ClothingColor>, ColorRepository>();
            services.AddScoped<IRepository<ClothingType>, TypeRepository>();


            services.AddScoped<IClothService, ClothService>();
            services.AddScoped<ISizeService, SizeService>();
            services.AddScoped<ITypeService, TypeService>();
            services.AddScoped<IColorService, ColorService>();




        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {

                using (var scope = app.ApplicationServices.CreateScope())
                {
                    var ctx = scope.ServiceProvider.GetService<ClothingContext>();
                    DbSeeder.Seed(ctx);
                }

                app.UseDeveloperExceptionPage();
            }
            else
            {
                using (var scope = app.ApplicationServices.CreateScope())
                {
                    var ctx = scope.ServiceProvider.GetService<ClothingContext>();
                    DbSeeder.Seed(ctx);
                }

                app.UseHsts();
            }

            app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
