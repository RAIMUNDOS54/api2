namespace api2.Configurations
{
    public class DbConfiguration : API2Configuration
    {
        private readonly string? ConnectionString;

        public DbConfiguration()
        {
            ConnectionString = builder?.Configuration.GetSection("ConnectionStrings")["prod"].ToString();

            Config();
        }

        internal sealed override void Config()
        {
            DbContext();
        }

        private void DbContext() => builder?.Services.AddDbContext<ExpenseDbContext>(o => o.UseSqlServer(ConnectionString));
    }
}
