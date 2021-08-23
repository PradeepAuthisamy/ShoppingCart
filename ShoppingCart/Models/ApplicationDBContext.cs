using Microsoft.EntityFrameworkCore;

namespace ShoppingCart.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<Books> Books { get; set; }
    }
}