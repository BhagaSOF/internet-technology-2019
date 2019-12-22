using System.ComponentModel.DataAnnotations;

namespace HotelWebApplication.Models
{
    public class User
    {
        [Key] public int Id { get; set; }

        [Display(Name = "Логин")]
        public string Login { get; set; }

        [Display(Name = "Пароль")]
        public string Password { get; set; }
    }
}