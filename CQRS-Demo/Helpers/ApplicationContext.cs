using CQRS_Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS_Demo.Helpers
{
    public class ApplicationContext : DbContext, IApplicationContext
    {
        public DbSet<Product> Products { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        { }
#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        public async Task<int> SaveChanges()
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
        {
            return await base.SaveChangesAsync();
        }
    }
}
