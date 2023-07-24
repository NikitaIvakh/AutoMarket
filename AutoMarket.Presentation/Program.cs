WebApplicationBuilder applicationBuilder = WebApplication.CreateBuilder(args);
WebApplication webApplication = applicationBuilder.Build();

webApplication.MapGet("/", () => "Hello World!");

webApplication.Run();
