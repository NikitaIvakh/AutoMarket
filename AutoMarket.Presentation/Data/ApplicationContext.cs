using AutoMarket.Presentation.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoMarket.Presentation.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options) { }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}