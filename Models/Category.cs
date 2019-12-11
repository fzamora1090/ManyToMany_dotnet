using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsAndCategories.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get;set; }

        [Required(ErrorMessage = "is required!")]
        [MinLength(2, ErrorMessage = "Must be longer than 2 characters")]
        [Display(Name = "Name")]
        public string Name { get;set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Association> Associations { get;set; }


    }
}