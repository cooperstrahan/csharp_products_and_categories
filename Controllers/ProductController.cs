using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductsAndCategories.Models;
using Microsoft.EntityFrameworkCore;

namespace ProductsAndCategories.Controllers
{
    public class ProductController : Controller
    {
        private ProductsAndCategoriesContext dbContext;
        public ProductController(ProductsAndCategoriesContext context)
        {
            dbContext = context;
        }

        [Route("products")]
        [HttpGet]
        public IActionResult Index()
        {
            List<Product> AllProducts = ProductList();
            
            MasterProduct MasterProduct = new MasterProduct(AllProducts);

            return View(MasterProduct);
        }

        [Route("products/new")]
        [HttpPost]
        public IActionResult NewProduct(MasterProduct NewProduct)
        {
            if(ModelState.IsValid)
            {
                Product Product = new Product(NewProduct);
                dbContext.Products.Add(Product);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                List<Product> AllProducts = ProductList();
                NewProduct.Products = AllProducts;
                return View("Index", NewProduct);
            } 
        }

        [Route("products/{id}")]
        [HttpGet]
        public IActionResult ViewProduct(int id)
        {
            AddCategory Product =  FindProductAndCategories(id);
            System.Console.WriteLine(Product.Existing.Count);
            return View(Product);
        }

        [Route("products/{id}/add")]
        [HttpPost]
        public IActionResult NewCategory(AddCategory category, int id)
        {
            AddCategory Product = FindProductAndCategories(id);
            Association newAssociation = new Association(id, category.CategoryId);
            newAssociation.Product = FindProductById(id);
            newAssociation.Category = FindCategoryById(category.CategoryId);

            if(ModelState.IsValid)
            {
                System.Console.WriteLine(id);
                if(category.CategoryId != 0)
                {
                    dbContext.Associations.Add(newAssociation);
                    dbContext.SaveChanges();
                    return RedirectToAction("ViewProduct", Product);
                }
                
                return RedirectToAction("ViewProduct", Product);
            }
            else
            {
                ModelState.AddModelError("CategoryId", "There is no category to add!");
                return RedirectToAction("ViewProduct", Product);
            }
            
        }

        public List<Product> ProductList()
        {
            List<Product> AllProducts = dbContext.Products
                .Include(product => product.Categories)
                .ThenInclude(category => category.Category)
                .ToList();

            return AllProducts;
        }

        public Product FindProductById(int id)
        {
            Product Product = dbContext.Products
                .Include(product => product.Categories)
                .ThenInclude(category => category.Category)
                .FirstOrDefault(p => p.ProductId == id);
            return Product;
        }

        public Category FindCategoryById(int id)
        {
            Category Category = dbContext.Categories
                .Include(c => c.Products)
                .ThenInclude(cat => cat.Product)
                .FirstOrDefault(categ => categ.CategoryId == id);
            return Category;
        }
        
        public AddCategory FindProductAndCategories(int id)
        {
            AddCategory AddCategory = new AddCategory();
            Product product = dbContext.Products
                .Include(prod => prod.Categories)
                .ThenInclude(category => category.Category)
                .FirstOrDefault(p => p.ProductId == id);

            List<Category> existing = dbContext.Categories
                .Include(cat => cat.Products)
                .Where(assoc=>assoc.Products
                .Any(pro=>pro.ProductId==id))
                .ToList();

            List<Category> available = dbContext.Categories
                .Include(cat => cat.Products)
                .Where(Category=>Category.Products
                .All(pro=>pro.ProductId!=id))
                .ToList();

            AddCategory.Product = product;
            AddCategory.Available = available;
            AddCategory.Existing = existing;          

            return AddCategory; 
        }
    }
}
