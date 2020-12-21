﻿using ShoppingApp.WebUI.Entity;
using ShoppingApp.WebUI.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ShoppingApp.WebUI.Repository.Concrete.EntityFramework
{
    public class EfCategoryRepository : EfGenericRepository<Category>, ICategoryRepository
    {
        public EfCategoryRepository(ShoppingContext context) : base(context)
        {
                
        }

        public ShoppingContext ShoppingContext
        {
            get { return context as ShoppingContext;  } // base class içerisindeki context nesnesini ShoppingContext olarak geri döndürdüm
        }

        public Category GetByName(string name)
        {
            return ShoppingContext.Categories.Where(i => i.CategoryName == name).FirstOrDefault();
        }
    }
}
