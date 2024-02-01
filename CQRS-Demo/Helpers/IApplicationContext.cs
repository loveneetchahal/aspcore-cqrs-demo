using CQRS_Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS_Demo.Helpers
{
    public interface IApplicationContext
    {
        DbSet<Product> Products { get; set; }

        Task<int> SaveChanges();
    }
}