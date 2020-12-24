using ShoppingApp.WebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.WebUI.Models
{
    public class Card
    {
        private List<CardLine> products = new List<CardLine>();
        public List<CardLine> Products => products;

        public void AddProduct(Product product, int quantity)
        {
            //eklemek istenen ürün ile aynı id'ye sahip ürün var mı ?
            var prd = products.Where(i => i.Product.ProductId == product.ProductId).FirstOrDefault();

            if (prd == null)
            {
                products.Add(new CardLine()
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                prd.Quantity += quantity;
            }
        }

        public void RemoveProduct(Product product)
        {
            products.RemoveAll(i => i.Product.ProductId == product.ProductId);
        }

        public double TotalPrice()
        {
            return products.Sum(i => i.Product.Price * i.Quantity); 
        }

        public void ClearAll()
        {
            products.Clear();
        }

    }

    public class CardLine
    {
        public int CartLineId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
