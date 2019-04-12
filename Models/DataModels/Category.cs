using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsAndCategories.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [MinLength(2)]
        public string CategoryName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public List<Association> Products { get; set; } = new List<Association>();

        public Category () {}

        public Category (MasterCategory category)
        {
            CategoryName = category.CategoryName;
        }
    }
}