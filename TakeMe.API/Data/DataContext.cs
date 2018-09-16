using Microsoft.EntityFrameworkCore;
using TakeMe.API.Models;

namespace TakeMe.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }
        public DbSet<Item> Items { get; set;}
        public DbSet<User> Users { get; set; }
    }
}