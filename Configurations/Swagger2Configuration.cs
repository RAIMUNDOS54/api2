namespace api2.Configurations
{
    public class Swagger2Configuration : API2Configuration
    {
        public Swagger2Configuration()
        {
            Config();
        }

        internal sealed override void Config()
        {
            ConfigSwagger();
        }

        private void ConfigSwagger()
        {
            builder?.Services.AddEndpointsApiExplorer();

            builder?.Services.AddSwaggerGen(option =>
            {
                option.SwaggerDoc("v1", new OpenApiInfo { Title = "Exctaworks api2 - Expenses API", Version = "v1" });
            });
        }

        public static void UseSwagger()
        {
            Program.WA.UseSwagger();

            Program.WA.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger-ui/v1/swagger.json", "Exactaworks api2 - Expenses API");
            });
        }
    }
}
