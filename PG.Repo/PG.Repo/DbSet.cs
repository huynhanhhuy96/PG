namespace PG.Repo
{
    using Microsoft.EntityFrameworkCore;
    using PG.Core.Models.UserEntities;

    public partial class PGContext
    {
        public DbSet<UserEntity> Users { get; set; }
    }
}