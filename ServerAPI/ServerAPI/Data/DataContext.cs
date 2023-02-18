using Microsoft.EntityFrameworkCore;
using ServerAPI.Models;

namespace ServerAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<OrderModel> orders { get; set; }
        public DbSet<CustomerModel> customers { get; set; }
    }
}
