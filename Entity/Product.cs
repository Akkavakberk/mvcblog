using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Web_UI.Entity
{
    public class Product
    {
        public int Id { get; set; }
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Ürün Açıklaması")]
        public string Description { get; set; }
        [DisplayName("Ürün Fiyatı")]
        public double Price { get; set; }
        [DisplayName("Ürün Stok Adeti")]
        public int Stock { get; set; }
        [DisplayName("Ürün Resmi")]
        public string image { get; set; }
        [DisplayName("Ürün Anasayfada mı?")]
        public bool IsHome { get; set; }
        [DisplayName("Ürün Onaylı mı?")]
        public bool IsApproved { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}