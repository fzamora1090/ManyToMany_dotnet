using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProductsAndCategories.Models
{
    public class PandCDBContext : DbContext
    {
        public PandCDBContext(DbContextOptions options) : base(options) { }
        // needed for DB / LINQ Queries
        public DbSet <Product> Products { get;set; }
        public DbSet <Category> Categories { get;set; }
        public DbSet <Association> Associations { get;set; }

    }
}