using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagement.Business.BusinessUnit;
using TeamManagement.Business.BusinessUnitMemebers;
using TeamManagement.Business.Employees;
using TeamManagement.Common.Middleware;
using TeamManagement.Context;
using TeamManagement.Mapper.BusinessUnit;
using TeamManagement.Respositories;
using TeamManagement.Respositories.BusinessUnitMemebers;
using TeamManagement.Respositories.Employees;

namespace TeamManagement
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
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddTransient<IBusinessUnitBusinessLayer, BusinessUnitBusinessLayer>();
            services.AddTransient<IBusinessUnitService, BusinessUnitService>();
            services.AddTransient<IEmployeesServices, EmployeesServices>();
            services.AddTransient<IEmployeesBusinessLayer, EmployeesBusinessLayer>();
            services.AddTransient<IBusinessUnitMemebersServices, BusinessUnitMemebersServices>();
            services.AddTransient<IBusinessUnitMemebersBusinessLayer, BusinessUnitMemebersBusinessLayer>();
            services.AddDbContext<TeamManagementDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("TeamManagementConnection")));
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TeamManagement", Version = "v1" });
            });
            services.AddControllersWithViews()
                .AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TeamManagement v1"));
            }          
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
         
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseMiddleware<CaptureRequest>();           
        }
    }
}
