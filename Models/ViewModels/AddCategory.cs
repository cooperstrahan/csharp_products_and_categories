using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsAndCategories.Models
{
    public class AddCategory
    {
        public int CategoryId { get; set; }
        public Product Product { get; set; }
        public List<Category> Available { get; set; }
        public List<Category> Existing { get; set; }
        public AddCategory() {}
    }
}