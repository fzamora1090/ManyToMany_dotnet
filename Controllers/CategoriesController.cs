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
    public class CategoriesController : Controller
    {
        private PandCDBContext _db;
        public CategoriesController(PandCDBContext context)
        {
            _db = context;
        }

        // CRUD/Routes and DB Queries
        [HttpGet("categories/all")]
        public IActionResult All()
        {
            // List<Category> allCategories = _db.Categories
            //     // .Include(c => c.Products)
            //     .Include(c => c.Associations)  //make sure to include the many to many association with .ThenInclude
            //     .ToList();
            MainModel dashboard = new MainModel();
            dashboard.allCategories = _db.Categories
                .Include(c => c.Associations)  
                .ToList();

            return View("CategoriesPage", dashboard);
        }

        // [HttpGet("categories/new")]
        // public IActionResult New()
        // {
        //     return View("NewCategory");
        // }

        [HttpPost("categories/create")]
        public IActionResult Create(MainModel newCategory)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(newCategory.Category);
                _db.SaveChanges();
                return RedirectToAction("All");
            }
            else{
                return View("CategoriesPage");
            }
        }

        [HttpGet("categories/{id}")]
        public IActionResult Details(int id)
        {
            Category selectedCategory = _db.Categories
                // .Include(c => c.Products)
                .Include(c => c.Associations)
                .FirstOrDefault(c => c.CategoryId == id);

                if (selectedCategory == null)
                    RedirectToAction("All");

                return View(selectedCategory);
        }

        [HttpGet("categories/edit")]
        public IActionResult Edit(int id)
        {
            Category toEdit = _db.Categories.FirstOrDefault(c => c.CategoryId == id);

            if (toEdit == null)
                return RedirectToAction("All");

            return View(toEdit);
        }
        

        [HttpPost("categories/update")]
        public IActionResult Update(Category toEdit, int id)
        {
            if (ModelState.IsValid)
            {
                Category dbCategory = _db.Categories.FirstOrDefault(c => c.CategoryId == id);

                if(dbCategory != null)
                {
                    dbCategory.Name = toEdit.Name;


                    _db.Categories.Update(dbCategory);
                    _db.SaveChanges();

                    return RedirectToAction("Details", new { id = dbCategory.CategoryId });
                }
                
            }
            return View("Edit", toEdit);
            
        }

        [HttpPost("categories/delete/{id}")]
        public IActionResult Delete(int id)
        {
            _db.Categories.Remove(
                _db.Categories.FirstOrDefault(c => c.CategoryId == id)
            );
            _db.SaveChanges();

            return RedirectToAction("All");
        }


    }
}