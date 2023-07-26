using coreDatabaseFirstApproachProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace coreDatabaseFirstApproachProject.Controllers
{
    public class DemoController : Controller
    {
        TrainingdbContext _context;
        public DemoController() 
        {
            _context = new TrainingdbContext();
        }
        public IActionResult Index()
        {
            /*var products = _context.Products.ToList();*/
            /*var products = _context.Products.Where(product => product.Category.Id == 1).ToList();*/
            /*int[] categories = { 1, 2 };*/
            /*var products = _context.Products.Where(product => categories.Contains(product.Category.Id)).ToList();*/
            /*var products = _context.Products.Select(product => new
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
                Total = product.Price * product.Quantity
            }).ToList();*/
            /*var products = _context.Products.Where(product => product.Price>= 10 && product.Status == true).ToList();*/
            /*var products = _context.Products.Where(product => product.Category.Id == 1 || product.Category.Id == 2).ToList();*/
            /*var products = _context.Products.Where(product => product.Name.StartsWith("M")).ToList();*/
            /*var products = _context.Products.Where(product => product.Name.EndsWith("1")).ToList();*/
            /*var products = _context.Products.Where(product => product.Name.Contains("M")).ToList();*/
            /*var products = _context.Products.OrderBy(product => product.Price).ToList();*/
            /*var products = _context.Products.OrderByDescending(product => product.Price).ToList();*/
            /*var products = _context.Products.OrderBy(product => product.Price).Skip(2).Take(3).ToList();*/
            /*var productCount = _context.Products.Count(product => product.Status == true);*/
            /*var totalQuantity = _context.Products.Sum(product => product.Quantity);*/
            /*var minQuantity = _context.Products.Min(product => product.Quantity);*/
            /*var maxQuantity = _context.Products.Max(product => product.Quantity);*/
            /*var averageQuantity = _context.Products.Average(product => product.Quantity);*/

            /*var products = _context.Products.GroupBy(product => product.CategoryId)
                .Select(product => new {
                    product.Key,
                    countProduct = product.Count(),
                    totalQunantity = product.Sum(p => p.Quantity),
                    minQunantity = product.Min(p => p.Quantity),
                    maxQunantity = product.Max(p => p.Quantity),
                    avrageQunantity = product.Average(p => p.Quantity)
                }).ToList();*/

            var products = _context.Products.Include(p => p.Category).ToList();
            return View(products);
        }

        public IActionResult Details()
        {
            var products = _context.Categories.Join(
               _context.Products,
               category => category.Id,
               product => product.CategoryId,
               (category, product) => new
               {
                   productId = product.Id,
                   productName = product.Name,
                   categoryId = category.Id,
                   categoryName = category.Name,
               }).ToList();
            ViewBag.products = products;
            return View(products);
        }
    }
}
