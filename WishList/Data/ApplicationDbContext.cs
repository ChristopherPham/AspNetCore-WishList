using Microsoft.EntityFrameworkCore;
using WishList.Models;
namespace WishList.Data
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext(DbContextOptions options) : base(options) { }
        public DbSet<Item> MyProperty { get; set; }

    }
}
