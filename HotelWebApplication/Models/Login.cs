using System.ComponentModel.DataAnnotations;

namespace HotelWebApplication.Models
{
    public class Login
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}