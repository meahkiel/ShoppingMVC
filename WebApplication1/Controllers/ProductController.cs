using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private ICollection<Catalog> _catalogs = new List<Catalog>();
        public ProductController()
        {
            _catalogs.Add(new Catalog
            {
                Id = Guid.NewGuid(),
                Description = "Test",
                Price = 2.3m
            });
        }
        public IActionResult Index()
        {
          


            return View(_catalogs);
        }
    }
}
