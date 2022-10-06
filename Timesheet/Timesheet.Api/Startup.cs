using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Timesheet.Domain.Repository;
using Timesheet.Domain.Services;
using Timesheet.Repository;
using Timesheet.Repository.Repositories;
using Timesheet.Service;

namespace Timesheet.Api
{
    public class Startup
    {
        public readonly string _cors = "cors";
        public IConfiguration Configuration { get; }

        public Startup (IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices (IServiceCollection services)
        {
            services.AddControllers ();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Timesheet", Version = "v1" });
            });

            services.AddDbContext<TimesheetDbContext>(item => item.UseSqlServer(Configuration.GetConnectionString("TimesheetConnectionString")));

            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddTransient<ICountryService, CountryService>();

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddTransient<ICategoryService, CategoryService>();

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IEmployeeService, EmployeeService>();

            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddTransient<IProjectService, ProjectService>();

            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddTransient<IClientService, ClientService>();

            services.AddScoped<ITimesheetByDayRepository, TimesheetByDayRepository>();
            services.AddTransient<ITimesheetService, TimesheetService>();

            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddTransient<IAddressService, AddressService>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            var provider = services.BuildServiceProvider();
            var configuration = provider.GetRequiredService<IConfiguration>();

            services.AddCors(options =>
            {
                options.AddPolicy(name:_cors,
                        builder =>
                        {
                            builder.WithOrigins("http://localhost:3000")
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                        });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(options => options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1"));
            }

            app.UseHttpsRedirection();
            app.UseCors(_cors);
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoint => endpoint.MapControllers());
        }
    }
}
