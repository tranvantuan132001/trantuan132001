using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WingtipToys.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                CategoryID = 1,
                CategoryName = "Cars"
                },
                 new Category
                {
                CategoryID = 2,
                CategoryName = "adc"
                },
                  new Category
                {
                CategoryID = 3,
                CategoryName = "abc"
                },
                   new Category
                {
                CategoryID = 4,
                CategoryName = "sdc"
                },
                    new Category
                {
                CategoryID = 5,
                CategoryName = "the rocks"
                },

            };
            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Convertible Car",Description = "This convertible car is fast! The engine is  powered by a neutrino based battery (not included)." +

                    "Power it up and let it go!",
                    ImagePath="carconvert.png",
                    UnitPrice = 22.50,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Convertible Car",Description = "This convertible car is fast! The engine is  powered by a neutrino based battery (not included)." +

                    "Power it up and let it go!",
                    ImagePath="carconvert.png",
                    UnitPrice = 19.50,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Convertible Car",Description = "This convertible car is fast! The engine is  powered by a neutrino based battery (not included)." +

                    "Power it up and let it go!",
                    ImagePath="carconvert.png",
                    UnitPrice = 17.90,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Convertible Car",Description = "This convertible car is fast! The engine is  powered by a neutrino based battery (not included)." +

                    "Power it up and let it go!",
                    ImagePath="carconvert.png",
                    UnitPrice = 21.90,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Convertible Car",Description = "This convertible car is fast! The engine is  powered by a neutrino based battery (not included)." +

                    "Power it up and let it go!",
                    ImagePath="carconvert.png",
                    UnitPrice = 34.98,
                    CategoryID = 1
                },


            };
            return products;
        }


        }
       

}