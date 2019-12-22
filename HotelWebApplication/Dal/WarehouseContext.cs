﻿using System.Data.Entity;
using HotelWebApplication.Models;

namespace HotelWebApplication.Dal
{
    public class WarehouseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Good> Goods { get; set; }
    }
}