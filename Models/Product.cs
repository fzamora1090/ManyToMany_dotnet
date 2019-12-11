using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsAndCategories.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get;set; }
        
        [Required(ErrorMessage = "is required!")]
        [MinLength(2, ErrorMessage = "Must be longer than 2 characters")]
        [Display(Name = "Name")]
        public string Name { get;set; }

        [Required(ErrorMessage = "is required!")]
        [MinLength(2, ErrorMessage = "Must be longer than 2 characters")]
        [Display(Name = "Description")]
        public string Description { get;set; }

        [Required(ErrorMessage = "is required!")]
        [Range(0.00, 1000000000.00, ErrorMessage = "Must be greater than $0")]
        [Display(Name = "Price")]
        public Decimal Price { get;set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Association> Associations { get;set; }
        public List<Category> Categories { get;set; }
        
        public List<Product> allProducts { get;set; }

    }
}