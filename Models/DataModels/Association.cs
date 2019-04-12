using System;
using System.ComponentModel.DataAnnotations;

namespace ProductsAndCategories.Models
{
    public class Association
    {
        [Key]
        public int AssociationId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public Association() {}
        public Association(int PId, int CId)
        {
            ProductId = PId;
            CategoryId = CId;
        }
    }

}