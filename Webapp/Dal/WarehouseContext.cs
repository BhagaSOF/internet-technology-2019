using System.Data.Entity;
using GoodSaleWebApplication.Models;

namespace GoodSaleWebApplication.Dal
{
    public class WarehouseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Good> Goods { get; set; }
    }
}