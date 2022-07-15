using System;
using System.Collections.Generic;

#nullable disable

namespace E_Commerce.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int? CatId { get; set; }
        public string ProductImage { get; set; }
        public string ProductMrp { get; set; }
        public string ProductFinal { get; set; }
        public int? ProductQuantity { get; set; }
    }
}
