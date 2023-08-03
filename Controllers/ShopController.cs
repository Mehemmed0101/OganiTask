using Microsoft.AspNetCore.Mvc;
using OganiTask.DataAccessLayer;
using Ogani.ViewModels;
using System;

namespace OganiTask.Controllers
{
    public class ShopController : Controller
    {

        private readonly AppDbContext _dbcontext;

        public ShopController(AppDbContext appdbContext)
        {
            _dbcontext = appdbContext;
        }

        public IActionResult Grid()
        {
            //var crProducts = _dbcontext.CaruselProducts.ToList();
            //var gridProducts = _dbcontext.GridProducts.ToList();

            //var viewModel = new ShopViewModel
            //{
            //    CaruselProducts = crProducts,
            //    GridProducts = gridProducts,
            //};

            return View();
        }
    }
}
