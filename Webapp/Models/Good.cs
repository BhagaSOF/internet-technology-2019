using System;
using System.ComponentModel.DataAnnotations;

namespace Webapp.Models
{
    public class Good
    {
        [Display(Name = "Номер товара")]
        [Key] public int Id { get; set; }

        [Display(Name = "Название")]
        public string Name { get; set; }

        [Display(Name = "Цена")]
        public int Price { get; set; }

        [Display(Name = "Поставщик")]
        public string Supplier { get; set; }

        [Display(Name = "В наличии")]
        public bool IsAvailable { get; set; }
    }
}