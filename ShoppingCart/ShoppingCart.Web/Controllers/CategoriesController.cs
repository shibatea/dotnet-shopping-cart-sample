using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Service.Infrastructure;
using ShoppingCart.Web.ViewModels;

namespace ShoppingCart.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategory _category;

        public CategoriesController(ICategory category)
        {
            _category = category;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var allCategories = _category.GetAllCategories();
            var vm = allCategories
                .Select(category => new CategoryViewModel
                {
                    Id = category.Id,
                    Name = category.Name
                })
                .ToList();
            return View(vm);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Details()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }
    }
}