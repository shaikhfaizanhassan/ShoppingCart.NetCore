using Microsoft.EntityFrameworkCore;

namespace Shopping_cart.Models
{
    public class ShopDbContext :DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext>options):base(options)
        {

        }
        public DbSet<Admin> admins { get; set; }
        public DbSet<Category> categories { get; set; } 
        public DbSet<Brand> brands { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
