using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Ogani.ViewModels;
using OganiTask.DataAccessLayer;

namespace Ogani.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var department = _dbContext.Departments.ToList();
            var category = _dbContext.Categories.ToList();
            var filter = _dbContext.Filters.ToList();
            var product = _dbContext.Products.Include(x => x.Filter).Take(8).ToList();
            var banner = _dbContext.Banners.ToList();
            var blog = _dbContext.Blogs.ToList();
            var topBanner = _dbContext.HomeTopBanners.ToList();

            var viewModel = new HomeViewModel
            {
                Departments = department,
                Categories = category,
                Filters = filter,
                Products = product,
                Banners = banner,
                Blogs = blog,
                HomeTopBanners = topBanner,
            };

            return View(viewModel);
        }
    }
}
