using Microsoft.AspNetCore.Mvc;
using ShoppingApp.WebUI.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        public ICategoryRepository repository;

        public CategoryController(ICategoryRepository _repository)
        {
            repository = _repository;
        }

        public IActionResult Index()
        {
            return View(repository.GetByName("Electronics"));
        }
    }
}
