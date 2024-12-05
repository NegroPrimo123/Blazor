using Microsoft.EntityFrameworkCore;

namespace Rabotaipj.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

            Products = Set<Product>();
        }

        public DbSet<Product> Products { get; set; } = null!;
    }
}
