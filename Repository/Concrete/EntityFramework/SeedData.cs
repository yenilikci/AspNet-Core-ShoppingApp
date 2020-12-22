 using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShoppingApp.WebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.WebUI.Repository.Concrete.EntityFramework
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.GetRequiredService<ShoppingContext>();

            context.Database.Migrate();

            if (!context.Products.Any())
            {
                var products = new[]
                {
                    new Product(){ProductName="Photo Camera",Price=153,Image="product1.jpg",isHome=true,isApproved=true,isFuture=true},
                    new Product(){ProductName="Wood Chair",Price=99,Image="product2.jpg",isHome=true,isApproved=true,isFuture=true},
                    new Product(){ProductName="Comfortable Sofa",Price=526,Image="product3.jpg",isHome=true,isApproved=true,isFuture=true},
                    new Product(){ProductName="Hand Bag",Price=125,Image="product4.jpg",isHome=true,isApproved=true,isFuture=true}, 
                    new Product(){ProductName="Sofa",Price=250,Image="product3.jpg",isHome=false,isApproved=false,isFuture=false}
                };

                context.Products.AddRange(products);

                var categories = new[]
                {
                     new Category(){CategoryName= "Electronics"},
                     new Category(){CategoryName= "Accesories"},
                     new Category(){CategoryName= "Furniture"},
                };

                context.Categories.AddRange(categories);


                var productCategories = new[]
                {
                    new ProductCategory(){Product = products[0],Category = categories[0] },
                    new ProductCategory(){Product = products[1],Category = categories[0] },
                    new ProductCategory(){Product = products[3],Category = categories[2] },
                    new ProductCategory(){Product = products[2],Category = categories[1] },
                };

                context.AddRange(productCategories);

                context.SaveChanges();
            }
        }
    }
}
