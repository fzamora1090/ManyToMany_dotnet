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

namespace ProductsAndCategories.Controllers
{
    public class ProductsController : Controller
    {
        private PandCDBContext _db;
        public ProductsController(PandCDBContext context)
        {
            _db = context;
        }

        // CRUD/Routes and DB Queries
        [HttpGet("products/all")]
        public IActionResult All()
        {
            // List<Product> allProducts = _db.Products
            //     .Include(p => p.Categories)
            //     .ThenInclude(p => p.Associations)  //make sure to include the many to many association with .ThenInclude
            //     .ToList();

            MainModel dashboard = new MainModel();
            dashboard.allProducts = _db.Products
                .Include(p => p.Categories)
                // .ThenInclude(p => p.Associations)  
                .ToList();

            return RedirectToAction("Index", "Home");
        }

        // [HttpGet("products/new")]
        // public IActionResult New()
        // {
        //     return View("NewProduct");
        // }

        [HttpPost("products/create")]
        public IActionResult Create(MainModel newProduct)
        {

            if (ModelState.IsValid)
            {
                _db.Products.Add(newProduct.Product);
                _db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else{
                return View("Index");

            }
        }
        [HttpGet("products/{id}")]
        public IActionResult Details(int id)
        {
            Product selectedProduct = _db.Products
                .Include(p => p.Categories)
                .ThenInclude(p => p.Associations)
                .FirstOrDefault(p => p.ProductId == id);

                if (selectedProduct == null)
                    RedirectToAction("All");

                return View(selectedProduct);
        }

        [HttpGet("products/edit")]
        public IActionResult Edit(int id)
        {
            Product toEdit = _db.Products.FirstOrDefault(p => p.ProductId == id);

            if (toEdit == null)
                return RedirectToAction("All");

            return View(toEdit);
        }
        

        [HttpPost("products/update")]
        public IActionResult Update(Product toEdit, int id)
        {
            if (ModelState.IsValid)
            {
                Product dbProduct = _db.Products.FirstOrDefault(p => p.ProductId == id);

                if(dbProduct != null)
                {
                    dbProduct.Name = toEdit.Name;
                    dbProduct.Description = toEdit.Description;
                    dbProduct.Price = toEdit.Price;

                    _db.Products.Update(dbProduct);
                    _db.SaveChanges();

                    return RedirectToAction("Details", new { id = dbProduct.ProductId });
                }
                
            }
            return View("Edit", toEdit);

        }

        [HttpPost("products/delete/{id}")]
        public IActionResult Delete(int id)
        {
            _db.Products.Remove(
                _db.Products.FirstOrDefault(p => p.ProductId == id)
            );
            _db.SaveChanges();

            return RedirectToAction("All");
        }


    }
}