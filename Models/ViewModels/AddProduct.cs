using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsAndCategories.Models
{
    public class AddProduct
    {
        public int ProductId { get; set; }
        public Category Category { get; set; }
        public List<Product> Available { get; set; }
        public List<Product> Existing { get; set; }
        public AddProduct() {}
    }
}