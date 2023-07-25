using AutoMarket.Presentation.Data;
using AutoMarket.Presentation.Data.Interfaces;
using AutoMarket.Presentation.Data.Models;
using AutoMarket.Presentation.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace AutoMarket.Presentation
{
    public class Startup
    {
        private readonly IConfigurationRoot _configurationRoot;

        public Startup(IWebHostEnvironment webHostEnvironment)
        {
            _configurationRoot = new ConfigurationBuilder().SetBasePath(webHostEnvironment.ContentRootPath).AddJsonFile("dbSettings.json").Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(scope => AutoMarketCart.GetCart(scope));

            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddTransient<ICars, CarRepository>();
            services.AddTransient<ICarsCategory, CategoryRepository>();

            services.AddDbContext<ApplicationContext>(options =>
            {
                options.UseNpgsql(_configurationRoot.GetConnectionString("DefaultConnection"));
            });

            services.AddMemoryCache();
            services.AddSession();
        }

        public void Configure(IApplicationBuilder applicationBuilder, IWebHostEnvironment hostingEnvironment)
        {
            applicationBuilder.UseDeveloperExceptionPage();
            applicationBuilder.UseStatusCodePages();
            applicationBuilder.UseStaticFiles();
            applicationBuilder.UseSession();
            applicationBuilder.UseMvcWithDefaultRoute();

            using (var scope = applicationBuilder.ApplicationServices.CreateScope())
            {
                ApplicationContext applicationContext = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
                DBObjects.Initial(applicationContext);
            }
        }
    }
}