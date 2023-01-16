using OrganizeIt.Tasks.Persistence.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace OrganizeIt.Tasks.Persistence.Contexts
{
    public class AppDbContextFactory : DesignTimeDbContextFactoryBase<AppDbContext>
    {
        protected override AppDbContext CreateNewInstance(DbContextOptions<AppDbContext> options)
        {
            return new AppDbContext(options);
        }
    }
}
