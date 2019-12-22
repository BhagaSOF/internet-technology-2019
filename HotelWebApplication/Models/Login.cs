using System.ComponentModel.DataAnnotations;

namespace HotelWebApplication.Models
{
    public class Login
    {
        [Required]
        [Display(Name = "Логин")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
    }
}