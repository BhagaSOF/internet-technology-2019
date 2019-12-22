using System.ComponentModel.DataAnnotations;

namespace HotelWebApplication.Models
{
    public class Client
    {
        [Key] public int Id { get; set; }

        public int PassportSeriesAndNumber { get; set; }

        public string FullName { get; set; }
    }
}