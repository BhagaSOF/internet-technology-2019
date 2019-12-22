using System;
using System.Data.Entity;
using HotelWebApplication.Dal;

namespace HotelWebApplication.Models
{
    public class HotelDbInitializer : DropCreateDatabaseAlways<WarehouseContext>
    {
        protected override void Seed(WarehouseContext db)
        {
            db.Users.Add(new User
            {
                Login = "admin",
                Password = "password"
            });
         

            base.Seed(db);
        }
    }
}