using System.Data.Entity;
using HotelWebApplication.Models;

namespace HotelWebApplication.Dal
{
    public class HotelContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}