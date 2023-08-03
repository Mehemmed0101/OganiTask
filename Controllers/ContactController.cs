using Microsoft.AspNetCore.Mvc;

using Ogani.ViewModels;
using OganiTask.DataAccessLayer;

namespace Ogani.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ContactController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IActionResult Index()
        {
            //var department = _dbContext.Departments.ToList();
            //var contact = _dbContext.Contacts.ToList();

            //var viewModel = new ContactViewModel
            //{
            //    Departments = department,
            //    Contacts = contact,
            //};

            return View();
        }
    }
}

