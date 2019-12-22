using System;
using System.ComponentModel.DataAnnotations;

namespace HotelWebApplication.Models
{
    public class Booking
    {
        [Key] public int Id { get; set; }

        [Display(Name = "Серия и номер паспорта клиента")]
        public int ClientPassportSeriesAndNumber { get; set; }

        [Display(Name = "ФИО клиента")]
        public string ClientFullName { get; set; }

        [Display(Name = "Номер комнаты")]
        public int RoomId { get; set; }

        public DateTime BookingDateTime { get; set; }

        [Display(Name = "Дата заезда")]
        public DateTime ArrivalDateTime { get; set; }

        [Display(Name = "Дата отъезда")]
        public DateTime DepartureDateTime { get; set; }

        [Display(Name = "Стоимость заказа")]
        public int OrderPrice { get; set; }
    }
}