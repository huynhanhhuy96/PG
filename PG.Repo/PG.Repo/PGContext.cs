namespace PG.Repo
{
    using Microsoft.EntityFrameworkCore;    

    public sealed partial class PGContext : DbContext
    {
        public PGContext(DbContextOptions options) : base(options: options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder: modelBuilder);
            // modelBuilder.ApplyConfiguration(configuration: new UserEntityTypeConfiguration());
        }
    }
}
