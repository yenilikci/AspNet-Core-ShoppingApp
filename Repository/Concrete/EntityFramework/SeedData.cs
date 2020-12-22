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
                    new Product(){ProductName="Photo Camera",Price=153,Image="product1.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır.",HtmlContent="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı <b>1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır.</b>",DateAdded=DateTime.Now.AddDays(-10)},
                    new Product(){ProductName="Wood Chair",Price=99,Image="product2.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır.",HtmlContent="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı <b>1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır.</b>",DateAdded=DateTime.Now.AddDays(-5)},
                    new Product(){ProductName="Comfortable Sofa",Price=526,Image="product3.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır.",HtmlContent="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı <b>1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır.</b>",DateAdded=DateTime.Now.AddDays(-2)},
                    new Product(){ProductName="Hand Bag",Price=125,Image="product4.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır.",HtmlContent="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı <b>1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır.</b>",DateAdded=DateTime.Now.AddDays(-7)}, 
                    new Product(){ProductName="Sofa",Price=250,Image="product3.jpg",IsHome=false,IsApproved=false,IsFeatured=false,Description="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır.",HtmlContent="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı <b>1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır.</b>",DateAdded=DateTime.Now.AddDays(-9)}
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


                var images = new[]
                {
                    new Image(){ImageName="product1.jpg",Product=products[0]},
                    new Image(){ImageName="product2.jpg",Product=products[0]},
                    new Image(){ImageName="product3.jpg",Product=products[0]},
                    new Image(){ImageName="product4.jpg",Product=products[0]},

                    new Image(){ImageName="product1.jpg",Product=products[1]},
                    new Image(){ImageName="product2.jpg",Product=products[1]},
                    new Image(){ImageName="product3.jpg",Product=products[1]},
                    new Image(){ImageName="product4.jpg",Product=products[1]},

                    new Image(){ImageName="product1.jpg",Product=products[2]},
                    new Image(){ImageName="product2.jpg",Product=products[2]},
                    new Image(){ImageName="product3.jpg",Product=products[2]},
                    new Image(){ImageName="product4.jpg",Product=products[2]},

                    new Image(){ImageName="product1.jpg",Product=products[3]},
                    new Image(){ImageName="product2.jpg",Product=products[3]},
                    new Image(){ImageName="product3.jpg",Product=products[3]},
                    new Image(){ImageName="product4.jpg",Product=products[3]}
                };

                context.Images.AddRange(images);


                var attributes = new[]
                {
                    new ProductAttribute(){Attribute="Display",Value="15.6",Product=products[0]},
                    new ProductAttribute(){Attribute="Processor",Value="Intel",Product=products[0]},
                    new ProductAttribute(){Attribute="Ram Memory",Value="8 GB",Product=products[0]},
                    new ProductAttribute(){Attribute="Hard Disk",Value="1 TB",Product=products[0]},
                    new ProductAttribute(){Attribute="Color",Value="Black",Product=products[0]},

                    new ProductAttribute(){Attribute="Display",Value="15.6",Product=products[1]},
                    new ProductAttribute(){Attribute="Processor",Value="Intel",Product=products[1]},
                    new ProductAttribute(){Attribute="Ram Memory",Value="8 GB",Product=products[1]},
                    new ProductAttribute(){Attribute="Hard Disk",Value="1 TB",Product=products[1]},
                    new ProductAttribute(){Attribute="Color",Value="Black",Product=products[1]},

                    new ProductAttribute(){Attribute="Display",Value="15.6",Product=products[2]},
                    new ProductAttribute(){Attribute="Processor",Value="Intel",Product=products[2]},
                    new ProductAttribute(){Attribute="Ram Memory",Value="8 GB",Product=products[2]},
                    new ProductAttribute(){Attribute="Hard Disk",Value="1 TB",Product=products[2]},
                    new ProductAttribute(){Attribute="Color",Value="Black",Product=products[2]}
                };

                context.ProductAttributes.AddRange(attributes);

                context.SaveChanges();
            }
        }
    }
}
