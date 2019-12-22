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

            db.Rooms.Add(new Room
            {
                Name = "Стандартный двухместный номер с 1 кроватью или 2 отдельными кроватями",
                NumberOfPeople = 2,
                CostPerDay = 2000,
                PhotoUrl = "/Content/Rooms/room0.jpg",
                Description =
                "Ванная комната в номере" + Environment.NewLine +
                "Бесплатная парковка" + Environment.NewLine +
                "Размер номера 24 м²" + Environment.NewLine +
                "Телефон" + Environment.NewLine +
                "Кондиционер" + Environment.NewLine +
                "Электрический чайник" + Environment.NewLine +
                "Курение: запрещено"
            }); // 0
            db.Rooms.Add(new Room
            {
                Name = "Стандартный двухместный номер с 2 отдельными кроватями",
                NumberOfPeople = 2,
                CostPerDay = 2000,
                PhotoUrl = "/Content/Rooms/room1.jpg",
                Description =
                "Собственная ванная комната" + Environment.NewLine +
                "Бесплатная парковка" + Environment.NewLine +
                "Размер номера 22 м²" + Environment.NewLine +
                "Телефон" + Environment.NewLine +
                "Кондиционер" + Environment.NewLine +
                "Электрический чайник" + Environment.NewLine +
                "Курение: запрещено"
            }); // 1
            db.Rooms.Add(new Room
            {
                Name = "Двухместный номер с 1 кроватью",
                NumberOfPeople = 2,
                CostPerDay = 2100,
                PhotoUrl = "/Content/Rooms/room2.jpg",
                Description =
                "Собственная ванная комната" + Environment.NewLine +
                "Бесплатная парковка" + Environment.NewLine +
                "Размер номера 26 м²" + Environment.NewLine +
                "Телефон" + Environment.NewLine +
                "Кондиционер" + Environment.NewLine +
                "Электрический чайник" + Environment.NewLine +
                "Курение: запрещено"
            }); // 2
            db.Rooms.Add(new Room
            {
                Name = "Двухместный номер «Комфорт» с 1 кроватью или 2 отдельными кроватями",
                NumberOfPeople = 2,
                CostPerDay = 2200,
                PhotoUrl = "/Content/Rooms/room3.jpg",
                Description =
                "Собственная ванная комната" + Environment.NewLine +
                "Бесплатная парковка" + Environment.NewLine +
                "Размер номера 25 м²" + Environment.NewLine +
                "Телефон" + Environment.NewLine +
                "Кондиционер" + Environment.NewLine +
                "Электрический чайник" + Environment.NewLine +
                "Курение: запрещено"
            }); // 3
            db.Rooms.Add(new Room
            {
                Name = "Номер-студио",
                NumberOfPeople = 2,
                CostPerDay = 2400,
                PhotoUrl = "/Content/Rooms/room4.jpg",
                Description =
                "Собственная ванная комната" + Environment.NewLine +
                "Бесплатная парковка" + Environment.NewLine +
                "Размер номера 25 м²" + Environment.NewLine +
                "Телефон" + Environment.NewLine +
                "Кондиционер" + Environment.NewLine +
                "Электрический чайник" + Environment.NewLine +
                "Курение: запрещено" + Environment.NewLine +
                 Environment.NewLine +
                "Номер-студио с кондиционером, телевизором и отдельным входом. Ванная комната укомплектована феном и бесплатными туалетно-косметическими принадлежностями." + Environment.NewLine +
                "Мини-кухня оснащена чайником, микроволновой печью и холодильником."
            }); // 4
            db.Rooms.Add(new Room
            {
                Name = "Улучшенный двухместный номер с 1 кроватью",
                NumberOfPeople = 2,
                CostPerDay = 2500,
                PhotoUrl = "/Content/Rooms/room5.jpg",
                Description =
                "Собственная ванная комната" + Environment.NewLine +
                "Бесплатная парковка" + Environment.NewLine +
                "Размер номера 25 м²" + Environment.NewLine +
                "Телефон" + Environment.NewLine +
                "Кондиционер" + Environment.NewLine +
                "Электрический чайник" + Environment.NewLine +
                "Курение: запрещено" + Environment.NewLine +
                "\n" +
                "Номер с 2 отдельными кроватями и отдельным входом."
            }); // 5
            db.Rooms.Add(new Room
            {
                Name = "Полулюкс с балконом",
                NumberOfPeople = 2,
                CostPerDay = 2600,
                PhotoUrl = "/Content/Rooms/room6.jpg",
                Description =
                "Собственная ванная комната" + Environment.NewLine +
                "Бесплатная парковка" + Environment.NewLine +
                "Размер номера 28 м²" + Environment.NewLine +
                "Телефон" + Environment.NewLine +
                "Кондиционер" + Environment.NewLine +
                "Электрический чайник" + Environment.NewLine +
                "Курение: запрещено" + Environment.NewLine +
                Environment.NewLine +
                "Полулюкс располагает кондиционером, телевизором с плоским экраном и собственной ванной комнатой." + Environment.NewLine +
                Environment.NewLine +
                "К услугам гостей балкон и гостиная зона с диваном."
            }); // 6
            db.Rooms.Add(new Room
            {
                Name = "Бунгало Делюкс",
                NumberOfPeople = 2,
                CostPerDay = 2900,
                PhotoUrl = "/Content/Rooms/room7.jpg",
                Description =
                "Собственная ванная комната" + Environment.NewLine +
                "Бесплатная парковка" + Environment.NewLine +
                "Размер номера 35 м²" + Environment.NewLine +
                "Телефон" + Environment.NewLine +
                "Кондиционер" + Environment.NewLine +
                "Электрический чайник" + Environment.NewLine +
                "Курение: запрещено" + Environment.NewLine +
                Environment.NewLine +
                "В этом отдельном доме имеется терраса. Предоставляется бесплатная частная парковка."
            }); // 7
            db.Rooms.Add(new Room
            {
                Name = "Люкс с балконом",
                NumberOfPeople = 2,
                CostPerDay = 3500,
                PhotoUrl = "/Content/Rooms/room8.jpg",
                Description =
                "Собственная ванная комната" + Environment.NewLine +
                "Бесплатная парковка" + Environment.NewLine +
                "Размер номера 34 м²" + Environment.NewLine +
                "Телефон" + Environment.NewLine +
                "Кондиционер" + Environment.NewLine +
                "Электрический чайник" + Environment.NewLine +
                "Курение: запрещено" + Environment.NewLine +
                Environment.NewLine +
                "Люкс располагает кондиционером, телевизором с плоским экраном и собственной ванной комнатой." + Environment.NewLine +
                Environment.NewLine +
                "К услугам гостей балкон и гостиная."
            }); // 8
            db.Rooms.Add(new Room
            {
                Name = "Стандартный одноместный номер",
                NumberOfPeople = 1,
                CostPerDay = 1700,
                PhotoUrl = "/Content/Rooms/room9.jpg",
                Description =
                "Собственная ванная комната" + Environment.NewLine +
                "Бесплатная парковка" + Environment.NewLine +
                "Размер номера 14 м²" + Environment.NewLine +
                "Телефон" + Environment.NewLine +
                "Кондиционер" + Environment.NewLine +
                "Электрический чайник" + Environment.NewLine +
                "Курение: запрещено" + Environment.NewLine +
                Environment.NewLine +
                "Номер с кондиционером, телевизором с плоским экраном и собственной ванной комнатой."
            }); // 9
            db.Rooms.Add(new Room
            {
                Name = "Улучшенный одноместный номер",
                NumberOfPeople = 1,
                CostPerDay = 1800,
                PhotoUrl = "/Content/Rooms/room10.jpg",
                Description =
                "Собственная ванная комната" + Environment.NewLine +
                "Бесплатная парковка" + Environment.NewLine +
                "Размер номера 16 м²" + Environment.NewLine +
                "Телефон" + Environment.NewLine +
                "Кондиционер" + Environment.NewLine +
                "Электрический чайник" + Environment.NewLine +
                "Курение: запрещено"
            }); // 10

            base.Seed(db);
        }
    }
}