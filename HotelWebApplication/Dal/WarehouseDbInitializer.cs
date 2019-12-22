using System.Data.Entity;
using HotelWebApplication.Dal;

namespace HotelWebApplication.Models
{
    public class WarehouseDbInitializer : DropCreateDatabaseAlways<WarehouseContext>
    {
        protected override void Seed(WarehouseContext db)
        {
            db.Users.Add(new User
            {
                Login = "admin",
                Password = "password"
            });

            db.Goods.Add(new Good
            {
                Name = "Vodka",
                Price = 600,
                Supplier = "Five lakes",
                IsAvailable = true
            });

            db.Goods.Add(new Good
            {
                Name = "Beer 4.7%",
                Price = 120,
                Supplier = "Tyxtin",
                IsAvailable = true
            });

            db.Goods.Add(new Good
            {
                Name = "Beer 3.0%",
                Price = 80,
                Supplier = "Baltika",
                IsAvailable = false
            });

            db.Goods.Add(new Good
            {
                Name = "Double Liker",
                Price = 1200,
                Supplier = "Sheridans",
                IsAvailable = true
            });

            db.Goods.Add(new Good
            {
                Name = "Samogon",
                Price = 800,
                Supplier = "Uncle grandpa",
                IsAvailable = true
            });

            db.Goods.Add(new Good
            {
                Name = "Cognac",
                Price = 1600,
                Supplier = "Hennessy",
                IsAvailable = false
            });

            db.Goods.Add(new Good
            {
                Name = "Beer 6.0%",
                Price = 600,
                Supplier = "Guinness",
                IsAvailable = true
            });

            db.Goods.Add(new Good
            {
                Name = "Cider",
                Price = 75,
                Supplier = "Apples company",
                IsAvailable = false
            });

            db.Goods.Add(new Good
            {
                Name = "Tequila",
                Price = 1300,
                Supplier = "1800 silver",
                IsAvailable = true
            });

            db.Goods.Add(new Good
            {
                Name = "Whiskey",
                Price = 800,
                Supplier = "Jack Daniels",
                IsAvailable = false
            });


            base.Seed(db);
        }
    }
}