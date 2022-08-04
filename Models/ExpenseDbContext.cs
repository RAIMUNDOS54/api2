namespace api2.Models
{
    public partial class ExpenseDbContext : DbContext
    {
        public ExpenseDbContext()
        {
        }

        public ExpenseDbContext(DbContextOptions<ExpenseDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Expense> Expenses { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=168.138.149.235;Database=EXPENSE;User ID=expense;Password=expense;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("expense");

            modelBuilder.Entity<Expense>(entity =>
            {
                entity.ToTable("EXPENSE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.DateRegister)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_REGISTER");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Tags)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TAGS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
