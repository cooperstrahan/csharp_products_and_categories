using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsAndCategories.Models
{
    public class MasterProduct
    {
        public List<Product> Products { get; set; }
        [Required]
        [MinLength(2)]
        public string ProductName { get; set; }
        [Required]
        [MinLength(2)]
        public string Description { get; set; }
        [Required]
        [Range(.01, double.MaxValue, ErrorMessage="The Product must cost at least one penny")]
        public double Price { get; set; }
        public MasterProduct() {}
        public MasterProduct(List<Product> products)
        {
            Products = products;
        }
    }
}