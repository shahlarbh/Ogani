using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ogani.DataAccessLayer;
using Ogani.DataAccessLayer.Entities;
using Ogani.ViewModels;

namespace Ogani.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ShopController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var department = _dbContext.Departments.ToList();
            var color = _dbContext.Colors.ToList();
            var size = _dbContext.Sizes.ToList();
            var product = _dbContext.Products.Skip(8).Take(12).ToList();

            var viewModel = new ShopViewModel
            {
                Departments = department,
                Colors = color,
                Sizes = size,
                Products = product,
            };

            return View(viewModel);
        }
    }
}
