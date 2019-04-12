using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsAndCategories.Models
{
    public class MasterCategory
    {
        public List<Category> Categories { get; set; }
        [Required]
        [MinLength(2)]
        public string CategoryName { get; set; }

        public MasterCategory() {}
        public MasterCategory(List<Category> category)
        {
            Categories = category;
        }
    }
}