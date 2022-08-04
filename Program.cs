using api2.Configurations;

internal class Program
{
    public static WebApplicationBuilder? WAB;
    public static WebApplication? WA;

    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        WAB = builder;

        _ = new MainConfiguration();

        var app = builder.Build();

        WA = app;

        _ = new ControllerConfiguration();

        _  = new UseConfiguration();

        //app.UsePathBase(new PathString("/api"));

        //app.UseSwagger();

        //app.UseSwaggerUI(c =>
        //{
        //    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Exactaworks api2 - Expenses API");
        //});

        //app.Run();
    }
}

