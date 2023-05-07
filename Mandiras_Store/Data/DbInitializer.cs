using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mandiras_Store.Entities;

namespace Mandiras_Store.Data
{
    public static class DbInitializer
    {
       public static void SeedData(IApplicationBuilder applicationBuilder)
       {    

        using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        {
            //StoreContext is the file that we used to send or get data from the database
            var context = serviceScope.ServiceProvider.GetService<StoreContext>();
            //to check if the database exist
            context.Database.EnsureCreated();

            if(context.Products.Any()) return;

            List<Product> products = new ()
        {
             new Product
                {
                    Name = "Tommy Hilfiger quality Shirt",
                    Description = " Quality vintage shirt for the real men",
                        
                    Price = 20000,
                    PictureUrl = "/images/products/sb-ang1.png",
                    Brand = "Tommy",
                    Type = "Shirt",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Lacoste Classic Shirt",
                    Description = "Lacoste Classic Fit White Dot Blue Longsleve shirt",
                    Price = 15000,
                    PictureUrl = "/images/products/sb-ang2.png",
                    Brand = "Lacoste",
                    Type = "Shirt",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "PRL strippled shirt",
                    Description =
                        "Quality stripped polo shirt.",
                    Price = 18000,
                    PictureUrl = "/images/products/sb-core1.png",
                    Brand = "Polo Raph",
                    Type = "Shirt",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "John Foster Twisted Sued",
                    Description =
                        "Quality twisted woven strap full suede leather Men's",
                    Price = 30000,
                    PictureUrl = "/images/products/sb-core2.png",
                    Brand = "John Foster",
                    Type = "Causal Shoe",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "J.M Weston Cofee Half Croc",
                    Description =
                        "Leather with Font Tassel Design.",
                    Price = 25000,
                    PictureUrl = "/images/products/sb-react1.png",
                    Brand = "J.M Weston",
                    Type = "Casual Shoe",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Billion Exquisite Belted Logo Designed",
                    Description =
                        "Billion Exquisite Belted Logo Designed.",
                    Price = 12000,
                    PictureUrl = "/images/products/sb-ts1.png",
                    Brand = "Billion Exquisite",
                    Type = "Shoe",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Authentic Men's Denim Palm Angels",
                    Description =
                        "Authentic Men's Denim With Palm Angels Black jeans",
                    Price = 1000,
                    PictureUrl = "/images/products/hat-core1.png",
                    Brand = "Denim",
                    Type = "Jeans",
                    QuantityInStock = 100
                },
                new Product
                { 
                    Name ="Givenchy Black Leather Biker Jacket",
                Description = "Givenchy Men's Classic Biker Jacket in Black Leather",
                Price = 25000,
                PictureUrl=  "/images/products/jacket-givenchy-black.png",
                Brand=  "Givenchy",
                Type = "Jacket",
                QuantityInStock = 30
                },
                new Product
                {
                    Name = "Hugo Boss White Dress Shirt",
                    Description = "Hugo Boss Men's Classic Fit Dress Shirt in White",
                    Price = 5500,
                    PictureUrl = "/images/products/shirt-hugo-white.png",
                    Brand = "Hugo Boss",
                    Type = "Shirts",
                    QuantityInStock = 65
                },
                new Product
                {
                    Name = "Adidas Ultraboost Running Shoes",
                    Description = "Adidas Men's Running Shoes with Ultraboost Technology",
                    Price = 10000,
                    PictureUrl = "/images/products/sneakers-adidas-ultraboost.png",
                    Brand = "Adidas",
                    Type = "Sneakers",
                    QuantityInStock = 40
                },
                new Product
                {
                    Name = "Ralph Lauren Blue Denim Jacket",
                    Description = "Ralph Lauren Men's Classic Denim Jacket in Blue",
                    Price = 12000,
                    PictureUrl = "/images/products/jacket-ralphlauren-denim-blue.png",
                    Brand = "Ralph Lauren",
                    Type = "Jacket",
                    QuantityInStock = 20
                },
                new Product
                {
                    Name ="Balenciaga Black Leather Wallet",
                    Description = "Balenciaga Men's Leather Wallet in Black",
                    Price = 7000,
                    PictureUrl = "/images/products/wallet-balenciaga-black.png",
                    Brand = "Balenciaga",
                    Type = "Accessories",
                    QuantityInStock = 50
                },
                new Product
                {
                    Name = "Armani Exchange Red Polo Shirt",
                    Description = "Armani Exchange Men's Classic Fit Polo in Red",
                    Price = 6000,
                    PictureUrl = "/images/products/shirt-armani-red.png",
                    Brand = "Armani Exchange",
                    Type = "Shirts",
                    QuantityInStock = 80,
                },
                new Product
                {
                    Name ="Calvin Klein Blue Skinny Jeans",
                    Description = "CK Men's Skinny Cut Blue Jeans",
                    Price = 6500,
                    PictureUrl =  "/images/products/jeans-ck-blue.png",
                    Brand = "Calvin Klein",
                    Type = "Jeans",
                    QuantityInStock = 50
                },
                new Product
                {
                    Name = "Versace Black Leather Jacket",
                    Description = "Versace Men's Classic Leather Jacket in Black",
                    Price = 30000,
                    PictureUrl = "/images/products/jacket-versace-black.png",
                    Brand = "Versace",
                    Type = "Jacket",
                    QuantityInStock = 25
                },
                new Product
                {
                    Name = "Gucci White Sneakers",
                    Description = "Gucci Men's Classic Sneakers in White",
                    Price = 15000,
                    PictureUrl = "/images/products/sneakers-gucci-white.png",
                    Brand = "Gucci",
                    Type = "Sneakers",
                    QuantityInStock = 35
                },
                new Product
                {
                    Name = "Prada Black Leather Belt",
                    Description = "Prada Men's Leather Belt in Black",
                    Price = 8000,
                    PictureUrl = "/images/products/belt-prada-black.png",
                    Brand = "Prada",
                    Type = "Accessories",
                    QuantityInStock = 60
                },
                new Product
                {
                    Name = "Dolce & Gabbana Blue Denim Jeans",
                    Description = "D&G Men's Classic Straight Cut Denim Jeans in Blue",
                    Price = 12000,
                    PictureUrl = "/images/products/jeans-dg-blue.png",
                    Brand = "Dolce & Gabbana",
                    Type = "Jeans",
                    QuantityInStock = 45
                },
            };
            
            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
            }
        }

        }
        
        
       
    
