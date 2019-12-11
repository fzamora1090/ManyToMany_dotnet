using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using ProductsAndCategories.Models;

namespace ProductsAndCategories.Models
{
    public class MainModel
    {
        public Category Category { get;set; }
        public Product Product { get;set; }
        public List<Category> allCategories { get;set; }

        public List<Product> allProducts { get;set; }
        public List<Association> allAssociations { get;set; }

    }
}