using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsAndCategories.Models;

namespace ProductsAndCategories.Controllers
{
    public class CategoryController : Controller
    {
        private ProductsAndCategoriesContext dbContext;
        public CategoryController(ProductsAndCategoriesContext context)
        {
            dbContext = context;
        }

        [Route("categories")]
        [HttpGet]
        public IActionResult Index()
        {
            List<Category> AllCategories = CategoryList();
            
            MasterCategory MasterCategory = new MasterCategory(AllCategories);

            return View(MasterCategory);
        }

        [Route("categories/new")]
        [HttpPost]
        public IActionResult NewCategory(MasterCategory NewCategory)
        {
            if(ModelState.IsValid)
            {
                Category Category = new Category(NewCategory);
                dbContext.Categories.Add(Category);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                List<Category> AllCategories = CategoryList();
                NewCategory.Categories = AllCategories;
                return View("Index", NewCategory);
            }
        }

        [Route("category/{id}")]
        [HttpGet]
        public IActionResult ViewCategory(int id)
        {
            AddProduct Category = FindCategoryAndProducts(id);
            return View(Category);
        }

        [Route("category/{id}/add")]
        [HttpPost]
        public IActionResult NewCategory(AddProduct product, int id)
        {
            AddProduct Category = FindCategoryAndProducts(id);
            Association newAssociation = new Association(product.ProductId, id);
            newAssociation.Product = FindProductById(id);
            newAssociation.Category = FindCategoryById(product.ProductId);

            if(ModelState.IsValid)
            {
                dbContext.Associations.Add(newAssociation);
                dbContext.SaveChanges();
                return RedirectToAction("ViewCategory", Category);
            }
            else
            {
                ModelState.AddModelError("ProductId", "There is no category to add!");
                return View("ViewCategory", Category);
            }
            
        }

        public List<Category> CategoryList()
        {
            List<Category> AllCategories = dbContext.Categories
                .Include(cat => cat.Products)
                .ThenInclude(prod => prod.Product)
                .ToList();

            return AllCategories;
        }

        public Category FindCategoryById(int id)
        {
            Category Category = dbContext.Categories
                .Include(c => c.Products)
                .ThenInclude(cat => cat.Product)
                .FirstOrDefault(categ => categ.CategoryId == id);
            return Category;
        }
        
        public Product FindProductById(int id)
        {
            Product Product = dbContext.Products
                .Include(product => product.Categories)
                .ThenInclude(category => category.Category)
                .FirstOrDefault(p => p.ProductId == id);
            return Product;
        }

        public AddProduct FindCategoryAndProducts(int id)
        {
            AddProduct AddProduct = new AddProduct();

            Category category = dbContext.Categories
                .Include(cat => cat.Products)
                .ThenInclude(prod => prod.Product)
                .FirstOrDefault(c => c.CategoryId == id);

            List<Product> existing = dbContext.Products
                .Include(prod => prod.Categories)
                .Where(cat=>cat.Categories
                .Any(cate=>cate.CategoryId==id))
                .ToList();
            
            List<Product> available = dbContext.Products
                .Include(prod => prod.Categories)
                .Where(cat=>cat.Categories
                .All(cate=>cate.CategoryId!=id))
                .ToList();

            AddProduct.Category = category;
            AddProduct.Available = available;
            AddProduct.Existing = existing;

            return AddProduct; 
        }
    }
}
