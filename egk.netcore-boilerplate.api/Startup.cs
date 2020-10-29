using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using egk.netcore_boilerplate.api.Data;
using egk.netcore_boilerplate.api.Data.Repositories;
using egk.netcore_boilerplate.api.Data.Repositories.Contracts;
using egk.netcore_boilerplate.api.Data.Services.Contracts;
using egk.netcore_boilerplate.api.Data.Services;

namespace egk.netcore_boilerplate.api
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvcCore()
                .SetCompatibilityVersion(CompatibilityVersion.Latest);

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            services.AddDbContext<NorthwindContext>(opts =>
                    opts.UseSqlServer(_configuration.GetConnectionString("NorthwindConnection")));
            services.AddScoped<IDBContext,NorthwindContext>();
            services.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));
            services.AddScoped(typeof(IBaseService<,>), typeof(BaseService<,>));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors("MyPolicy");

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
