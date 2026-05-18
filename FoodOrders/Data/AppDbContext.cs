using FoodOrders.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodOrders.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Food> Foods { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {}
    }
}
