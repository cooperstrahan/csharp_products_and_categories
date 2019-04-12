using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsAndCategories.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [MinLength(2)]
        public string ProductName { get; set; }
        [Required]
        [MinLength(2)]
        public string Description { get; set; }
        [Required]
        [Range(.01, double.MaxValue, ErrorMessage="The Product must cost at least one penny")]
        public double Price { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Association> Categories { get; set; } = new List<Association>(); 

        public Product() {}

        public Product(MasterProduct NewProduct)
        {
            ProductName = NewProduct.ProductName;
            Description = NewProduct.Description;
            Price = NewProduct.Price;
        }
    }
}