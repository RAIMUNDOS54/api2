namespace api2.Configurations
{
    public sealed class MainConfiguration
    {
        public MainConfiguration()
        {
            _ = new DbConfiguration();
            _ = new Swagger2Configuration();
       }
    }
}
