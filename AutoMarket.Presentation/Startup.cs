namespace AutoMarket.Presentation
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
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