using System.Data.Entity;
using Webapp.Models;

namespace Webapp.Dal
{
    public class WarehouseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Good> Goods { get; set; }
    }
}