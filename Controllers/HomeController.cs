using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShoppingApp.WebUI.Entity;
using ShoppingApp.WebUI.Models;
using ShoppingApp.WebUI.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IProductRepository repository;
        public IUnitOfWork uow;

        public HomeController(IProductRepository _repository, IUnitOfWork _uow )
        {
            repository = _repository;
            uow = _uow; 
        }

        public IActionResult Index()
        {
            return View(uow.Products.GetAll().Where(i => i.IsApproved && i.IsHome).ToList());  
            //return View(repository.GetAll());
        }

        public IActionResult Details(int id)
        {
            return View(uow.Products.Get(id));
        }

        public IActionResult Create()
        {
            var prd = new Product()
            {
                ProductName = "Yeni Ürün",
                Price = 1000
            };
            uow.Products.Add(prd);
            uow.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
