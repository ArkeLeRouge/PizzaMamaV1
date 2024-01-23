using Microsoft.EntityFrameworkCore;
using PizzaMama.Models;

namespace PizzaMama.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Pizza> Pizzas { get; set; }
    }
}
