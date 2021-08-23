using Microsoft.EntityFrameworkCore;

namespace ShoppingCart.Models.Interface
{
    public interface IApplicationDBContext
    {
        public DbSet<Books> Books { get; set; }
    }
}