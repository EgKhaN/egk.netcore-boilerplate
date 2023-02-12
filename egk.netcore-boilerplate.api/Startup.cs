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
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Options;
using System.Linq;
using Newtonsoft.Json.Serialization;
using Microsoft.OpenApi.Models;

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

            services
            .AddControllersWithViews()
            .AddNewtonsoftJson(opt =>
                 opt.SerializerSettings.ContractResolver = new DefaultContractResolver()); //For returning object names as they are defined,not camelCase
            services.AddControllersWithViews(options =>
            {
                options.InputFormatters.Insert(0, GetJsonPatchInputFormatter());
            });

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            services.AddSwaggerGen();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Implement Swagger UI",
                    Description = "A simple example to Implement Swagger UI",
                });
            });

            services.AddDbContext<NorthwindContext>(opts =>
                    opts.UseSqlServer(_configuration.GetConnectionString("NorthwindConnection")));

            services.AddDbContext<TaskSystemContext>(opts =>
                    opts.UseSqlServer(_configuration.GetConnectionString("TaskSystemAzureConnection")));
            services.AddScoped<IDBContext, NorthwindContext>();
            services.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));
            services.AddScoped(typeof(IBaseService<,>), typeof(BaseService<,>));

            services.AddHttpContextAccessor();
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

            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Showing API V1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
        private static NewtonsoftJsonPatchInputFormatter GetJsonPatchInputFormatter()
        {
            var builder = new ServiceCollection()
                .AddLogging()
                .AddMvc()
                .AddNewtonsoftJson()
                .Services.BuildServiceProvider();

            return builder
                .GetRequiredService<IOptions<MvcOptions>>()
                .Value
                .InputFormatters
                .OfType<NewtonsoftJsonPatchInputFormatter>()
                .First();
        }
    }
}
