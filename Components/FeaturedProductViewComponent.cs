using Microsoft.AspNetCore.Mvc;
using ShoppingApp.WebUI.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.WebUI.Components
{
    public class FeaturedProductViewComponent : ViewComponent
    {
        private IProductRepository repository;

        public FeaturedProductViewComponent(IProductRepository _repository)
        {
            repository = _repository;
        }

        public IViewComponentResult Invoke()
        {
            return View(repository.GetAll().Where(i => i.IsApproved && i.IsFeatured).ToList());
        }


    }
}
