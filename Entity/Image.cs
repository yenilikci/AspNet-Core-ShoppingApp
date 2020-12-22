using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.WebUI.Entity
{
    public class Image
    {
        public int ImageId { get; set; }
        public string ImageName { get; set; }
        public int ProductId { get; set; } //Her bir ürün resmini, ürün ile ilişkilendirebilmek için
        public Product Product { get; set; } //Image üzerinden ürüne geçebilmek için ~ Navigation Properties
    }
}
