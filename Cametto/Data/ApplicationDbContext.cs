using Cametto.Models;
using Microsoft.EntityFrameworkCore;
using static Cametto.Models.Address;

namespace Cametto.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<AddressModel> Addresses { get; set; }
        public DbSet<CustomerModel> CustomerModels { get; set; }

        public DbSet<FoodDetail> FoodDetails { get; set; }

        public DbSet<FoodItem> FoodItems { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }

        public DbSet<Restrurant> Restrurants { get; set; }
        public DbSet<BillModel> BillModels { get; set; }
        public DbSet<FullAddress> fullAddresses { get; set; }
        public DbSet<Registration> Registrations { get; set; }

    }
}
