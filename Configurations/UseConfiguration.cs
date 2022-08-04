namespace api2.Configurations
{
    public class UseConfiguration : API2Configuration
    {
        public UseConfiguration()
        {
            Config();
        }

        internal override void Config()
        {
            ConfigUse();
        }

        private void ConfigUse()
        {
            UsePathbase("/api");

            Swagger2Configuration.UseSwagger();

            Run();
        }

        private void Run()
        {
            app?.Run();
        }

        private void UsePathbase(string path)
        {
            app?.UsePathBase(new PathString(path));
        }
    }
}