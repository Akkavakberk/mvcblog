using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web_UI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category(){Name = "Kamera",Description="Kamera vb. ürünleri"},
                new Category(){Name = "Bilgisayar",Description="Bilgisayar vb. ürünleri"},
                new Category(){Name = "Telefon",Description="Telefon vb. ürünleri"},
                new Category(){Name = "Televizyon",Description="Televizyon vb. ürünleri"},
                new Category(){Name = "Tablet",Description="Tablet vb. ürünleri"},
                new Category(){Name = "Saat",Description="Saat vb. ürünleri"}
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            List<Product> urunler = new List<Product>()
            {
                new Product(){Name="Samsung S9",
                    Description ="Android Telefon",
                    Price =659,
                    Stock =500,
                    IsApproved=true,
                    CategoryId=3,
                    IsHome=true,
                    image="1.jpg"
                },new Product(){Name="Samsung Smart Tv",
                    Description ="Akıllı 4K Televizyon",
                    Price =359,
                    Stock =470,
                    IsApproved=true,
                    CategoryId=4,
                    IsHome=true,
                    image="5.jpg"
                },new Product(){Name="Canon Q874",
                    Description ="FULL HD 48mpx",
                    Price =659,
                    Stock =500,
                    IsApproved=true,
                    CategoryId=1,
                    IsHome=true,
                    image="2.jpg"
                },new Product(){Name="Lenovo Ideapad",
                    Description ="Intel i66300HQ gtx 950",
                    Price =659,
                    Stock =500,
                    IsApproved=true,
                    CategoryId=2,
                    IsHome=true,
                    image="4.jpg"
                },new Product(){Name="Apple",
                    Description ="8.0 inch Tablet",
                    Price =659,
                    Stock =500,
                    IsApproved=true,
                    CategoryId=5,
                    IsHome=true,
                    image="3.jpg"
                },new Product(){Name="Samsung S9",
                    Description ="Android Telefon",
                    Price =659,
                    Stock =500,
                    IsApproved=true,
                    CategoryId=3,
                    IsHome=true,
                    image="1.jpg"
                },new Product(){Name="Samsung Smart Tv",
                    Description ="Akıllı 4K Televizyon",
                    Price =359,
                    Stock =470,
                    IsApproved=true,
                    CategoryId=4,
                    IsHome=true,
                    image="5.jpg"
                },new Product(){Name="Canon Q874",
                    Description ="FULL HD 48mpx",
                    Price =659,
                    Stock =500,
                    IsApproved=true,
                    CategoryId=1,
                    IsHome=true,
                    image="2.jpg"
                },new Product(){Name="Lenovo Ideapad",
                    Description ="Intel i66300HQ gtx 950",
                    Price =659,
                    Stock =500,
                    IsApproved=true,
                    CategoryId=2,
                    IsHome=true,
                    image="4.jpg"
                },new Product(){Name="Apple",
                    Description ="8.0 inch Tablet",
                    Price =659,
                    Stock =500,
                    IsApproved=true,
                    CategoryId=5,
                    IsHome =true,
                    image="3.jpg"
                }, new Product(){Name="Samsung S9",
                    Description ="Android Telefon",
                    Price =659,
                    Stock =500,
                    IsApproved=true,
                    CategoryId=3,
                    IsHome=true,
                    image="1.jpg"
                },new Product(){Name="Samsung Smart Tv",
                    Description ="Akıllı 4K Televizyon",
                    Price =359,
                    Stock =470,
                    IsApproved=true,
                    CategoryId=4,
                    IsHome=true,
                    image="5.jpg"
                },new Product(){Name="Canon Q874",
                    Description ="FULL HD 48mpx",
                    Price =659,
                    Stock =500,
                    IsApproved=true,
                    CategoryId=1,
                    IsHome=true,
                    image="2.jpg"
                },new Product(){Name="Lenovo Ideapad",
                    Description ="Intel i66300HQ gtx 950",
                    Price =659,
                    Stock =500,
                    IsApproved=true,
                    CategoryId=2,
                    IsHome=true,
                    image="4.jpg"
                },new Product(){Name="Apple",
                    Description ="8.0 inch Tablet",
                    Price =659,
                    Stock =500,
                    IsApproved=true,
                    CategoryId=5,
                    IsHome=true,
                    image ="3.jpg"
                },new Product(){Name="Samsung S9",
                    Description ="Android Telefon",
                    Price =659,
                    Stock =500,
                    IsApproved=true,
                    CategoryId=3,
                    IsHome=true,
                    image="1.jpg"
                },new Product(){Name="Samsung Smart Tv",
                    Description ="Akıllı 4K Televizyon",
                    Price =359,
                    Stock =470,
                    IsApproved=true,
                    CategoryId=4,
                    IsHome=true,
                    image="5.jpg"
                },new Product(){Name="Canon Q874",
                    Description ="FULL HD 48mpx",
                    Price =659,
                    Stock =500,
                    IsApproved=true,
                    CategoryId=1,
                    IsHome=true,
                    image="2.jpg"
                },new Product(){Name="Lenovo Ideapad",
                    Description ="Intel i66300HQ gtx 950",
                    Price =659,
                    Stock =500,
                    IsApproved=true,
                    CategoryId=2,
                    IsHome=true,
                    image="4.jpg"
                },new Product(){Name="Apple",
                    Description ="8.0 inch Tablet",
                    Price =659,
                    Stock =500,
                    IsApproved=true,
                    CategoryId=5,
                    IsHome =true,
                    image="3.jpg"
                }
            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();

            base.Seed(context);
        }

    }
}