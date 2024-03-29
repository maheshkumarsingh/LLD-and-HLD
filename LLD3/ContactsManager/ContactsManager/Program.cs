using ServiceContracts;
using Services;

namespace ContactsManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            //add services into IOC container
            builder.Services.AddSingleton<ICountriesService, CountriesService>();

            builder.Services.AddSingleton<IPersonService, PersonsService>();
            var app = builder.Build();

            if(builder.Environment.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseStaticFiles();
            app.UseRouting();
            app.MapControllers();

            app.Run(); 
        }
    }
}
