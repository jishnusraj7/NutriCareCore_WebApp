using Microsoft.EntityFrameworkCore;
using NutriCareCore_WebApp.Models;

namespace NutriCareCore_WebApp.Data   
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Dish> Dish { get; set; }
        public DbSet<NSysEthnic> NSysEthnic { get; set; }
        public DbSet<NSysFoodHabit> NSysFoodHabit { get; set; }
        public DbSet<NSysFoodCategory> NSysFoodCategory { get; set; }
    }
}
