namespace api2.Configurations
{
    public abstract class API2Configuration
    {
        protected readonly WebApplicationBuilder? builder = Program.WAB;

        protected readonly WebApplication? app = Program.WA;

        internal abstract void Config();
    }
}