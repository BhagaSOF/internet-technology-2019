using System.ComponentModel.DataAnnotations;

namespace HotelWebApplication.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Название")]
        [Required(ErrorMessage = "Введите название")]
        [MaxLength(128, ErrorMessage = "Максимальная длина названия — 128 символов")]
        public string Name { get; set; }

        [Display(Name = "Количество людей")]
        [Required(ErrorMessage = "Введите количество людей от 1-го до 10-ти человек")]
        [Range(1, 10)]
        public int NumberOfPeople { get; set; }

        [Display(Name = "Стоимость за сутки, руб.")]
        [Required(ErrorMessage = "Введите стоимость за сутки в руб.")]
        [Range(0, 10000)]
        public int CostPerDay { get; set; }

        [Display(Name = "Изображение")]
        public string PhotoUrl { get; set; }

        [Display(Name = "Описание")]
        [Required(ErrorMessage = "Добавьте описание")]
        public string Description { get; set; }
    }
}