﻿using Evidence_08.Models;
using System.ComponentModel.DataAnnotations;

namespace Evidence_08.ViewModels.Input
{
    public class ProductEditModel
    {
        public int ProductId { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = default!;


        public IFormFile? Picture { get; set; } = default!;

        [Required]
        [DataType(DataType.Currency)]
        public decimal UnitPrice { get; set; }

        [EnumDataType(typeof(SellUnit))]
        public SellUnit SellUnit { get; set; }

        public virtual List<ProductInventory> ProductInventories { get; set; } = new List<ProductInventory>();
    }
}
