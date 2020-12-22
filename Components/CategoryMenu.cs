﻿using Microsoft.AspNetCore.Mvc;
using ShoppingApp.WebUI.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.WebUI.Components
{
    public class CategoryMenu : ViewComponent
    {
        private ICategoryRepository repository;

        public CategoryMenu(ICategoryRepository _repository)
        {
            repository = _repository;
        }

        public IViewComponentResult Invoke()
        {
            return View(repository.GetAllWidthProductCount());
        }

    }
}
