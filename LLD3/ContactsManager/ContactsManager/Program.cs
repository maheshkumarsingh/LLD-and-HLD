using ServiceContracts;
using Services;
using Microsoft.EntityFrameworkCore;
using Entities;
using RepositoryContracts;
using Repositories;
using Serilog;
namespace ContactsManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Serilog
            builder.Host.UseSerilog((HostBuilderContext context, IServiceProvider services, LoggerConfiguration configuration) =>
            {
                configuration
                .ReadFrom.Configuration(context.Configuration)
                .ReadFrom.Services(services);
            });
            //Logging
            //builder.Host.ConfigureLogging(loggingProvider =>
            //{
            //    loggingProvider.ClearProviders();
            //    loggingProvider.AddConsole();
            //    loggingProvider.AddDebug();
            //    loggingProvider.AddEventLog();
            //});
            builder.Services.AddControllersWithViews();

            builder.Services.AddHttpLogging(options =>
            {
                options.LoggingFields =
                Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.RequestProperties |
                Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.ResponsePropertiesAndHeaders;

            });
            //add services into IOC container
            builder.Services.AddScoped<ICountriesService, CountriesService>();
            builder.Services.AddScoped<IPersonService, PersonsService>();
            builder.Services.AddScoped<ICountriesRepository, CountriesRepository>();
            builder.Services.AddScoped<IPersonRepository, PersonsRepository>();
            builder.Services.AddDbContext<PersonsDbContext>
                (
                    options =>
                    {
                        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
                    }
                );
            
            WebApplication app = builder.Build();

            app.UseSerilogRequestLogging();

            if (builder.Environment.IsDevelopment())
                app.UseDeveloperExceptionPage();
            //HTTP logging
            app.UseHttpLogging();
            
            Rotativa.AspNetCore.RotativaConfiguration.Setup("wwwroot",wkhtmltopdfRelativePath: "Rotativa");
            app.UseStaticFiles();
            app.UseRouting();
            app.MapControllers();

            app.Run();
        }
    }
}
