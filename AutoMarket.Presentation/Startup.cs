using AutoMarket.Presentation.Data.Interfaces;
using AutoMarket.Presentation.Data.Mocks;

namespace AutoMarket.Presentation
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddTransient<ICarsCategory, MockCategory>();
            services.AddTransient<ICars, MockCars>();
        }

        public void Configure(IApplicationBuilder applicationBuilder, IWebHostEnvironment hostingEnvironment)
        {
            applicationBuilder.UseDeveloperExceptionPage();
            applicationBuilder.UseStatusCodePages();
            applicationBuilder.UseStaticFiles();
            applicationBuilder.UseMvcWithDefaultRoute();
        }
    }
}