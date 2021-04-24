namespace PG.Cross.IoC
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using PG.Repo;

    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddDbContext<PGContext>((DbContextOptionsBuilder options) => options.UseSqlServer(
                connectionString: "Server=.\\SQLEXPRESS;Database=QLSinhVien;Trusted_Connection=True;MultipleActiveResultSets=true"));
        }
    }
}