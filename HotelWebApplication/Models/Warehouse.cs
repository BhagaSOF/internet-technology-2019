using System;
using System.ComponentModel.DataAnnotations;

namespace HotelWebApplication.Models
{
    public class Warehouse
    {
        [Display(Name = "Номер товара")]
        [Key] public int ItemId { get; set; }

        [Display(Name = "Название")]
        public string ItemName { get; set; }

        [Display(Name = "Цена")]
        public int ItemPrice { get; set; }

        [Display(Name = "Поставщик")]
        public string SupplierName { get; set; }

        [Display(Name = "В наличии")]
        public bool IsAvailable { get; set; }
    }
}