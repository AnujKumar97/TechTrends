using Microsoft.EntityFrameworkCore;
using TechTrends.Models;

namespace TechTrends.Services
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}
