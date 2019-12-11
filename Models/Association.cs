using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsAndCategories.Models
{
    public class Association
    {
        [Key]  //Denotes PK 
        public int AssociationId { get;set; }

        public int ProductId { get;set; } // FK

        public int CategoryId { get;set; } // FK
        // need both keys on Association table fopr Many - Many Associations / Navigations
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdateAt { get; set; } = DateTime.Now;
        /* 
            Navigation properties
            Not stored in DB, just used
            by Entity Framework to be able
            to use .include to get the full
            info from related classes
        */
        public Product Product { get;set; }
        public Category Category { get;set; }
    }
}