using System;
using System.Data.Entity;
using HotelWebApplication.Dal;

namespace HotelWebApplication.Models
{
    public class HotelDbInitializer : DropCreateDatabaseAlways<HotelContext>
    {
        protected override void Seed(HotelContext db)
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