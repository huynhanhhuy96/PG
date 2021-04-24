namespace PG.Repo.EntityConfigurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using PG.Core.Models.UserEntities;

    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable(name: "USERS");
            builder.HasKey(c => c.Id).HasName(name: "manv");
            builder.Property(c => c.Id).HasColumnName(name: "manv");
            builder.Property(c => c.Name).HasColumnName(name: "hoten");
        }
    }
}