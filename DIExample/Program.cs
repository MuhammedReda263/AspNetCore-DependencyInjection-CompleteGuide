using ServiceContract;
using Services;

namespace DIExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IcitiesService, CitiesService>();
            // Types of this registers
            //1) AddSingleton => create object at first time then give this same object to the everyone asked , just dispose when application shut down
            //2) AddTransient => create new object for every request and every inject
            //3) AddScoped => create new object for every request and not per every inject
            //                [the two injects take the same object per every request]


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
