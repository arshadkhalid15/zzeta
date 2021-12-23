using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>{

                new Product{
                    Name="Angular Speedster Board 2000",
                    Description="This is a test description 1",
                    Price=2000,
                    PictureURL="/images/products/sb-ang1.png",
                    Brand="Angular",
                    Type="Boards",
                    QuantityInStock=100
                },
                new Product{
                    Name="Speedster 2200",
                    Description="This is a test description 2",
                    Price=4000,
                    PictureURL="/images/products/sb-ang2.png",
                    Brand="Angular 2",
                    Type="Boards",
                    QuantityInStock=200
                },
                new Product{
                    Name="Boot Board 3200",
                    Description="This is a test description 3",
                    Price=2500,
                    PictureURL="/images/products/boot-ang1.png",
                    Brand="Angular",
                    Type="Boots",
                    QuantityInStock=150
                },
                new Product{
                    Name="Boot Board 3500",
                    Description="This is a test description 4",
                    Price=3200,
                    PictureURL="/images/products/boot-ang2.png",
                    Brand="Angular",
                    Type="Boots",
                    QuantityInStock=100
                },
                new Product{
                    Name="Boot Board 0010",
                    Description="This is a test description 5",
                    Price=1200,
                    PictureURL="/images/products/boot-core1.png",
                    Brand="Core",
                    Type="Boots",
                    QuantityInStock=100
                },
                new Product{
                    Name="Boot Board 2222",
                    Description="This is a test description 6",
                    Price=1800,
                    PictureURL="/images/products/boot-core2.png",
                    Brand="Core",
                    Type="Boots",
                    QuantityInStock=50
                },
                new Product{
                    Name="Boot Board 8600",
                    Description="This is a test description 7",
                    Price=3500,
                    PictureURL="/images/products/boot-redis1.png",
                    Brand="Redis",
                    Type="Boots",
                    QuantityInStock=10
                },
                new Product{
                    Name="Glove 1",
                    Description="This is a test description 8",
                    Price=500,
                    PictureURL="/images/products/glove-code1.png",
                    Brand="Code",
                    Type="Glove",
                    QuantityInStock=1000
                },
                new Product{
                    Name="Glove 2",
                    Description="This is a test description 9",
                    Price=510,
                    PictureURL="/images/products/glove-code2.png",
                    Brand="Code",
                    Type="Glove",
                    QuantityInStock=800
                },
                new Product{
                    Name="Glove 3",
                    Description="This is a test description 10",
                    Price=400,
                    PictureURL="/images/products/glove-react1.png",
                    Brand="React",
                    Type="Glove",
                    QuantityInStock=1000
                },
                new Product{
                    Name="Glove 4",
                    Description="This is a test description 11",
                    Price=550,
                    PictureURL="/images/products/glove-react2.png",
                    Brand="React",
                    Type="Glove",
                    QuantityInStock=450
                },
                new Product{
                    Name="Hat 1",
                    Description="This is a test description 12",
                    Price=750,
                    PictureURL="/images/products/hat-core1.png",
                    Brand="Core",
                    Type="Hat",
                    QuantityInStock=1000
                },
                new Product{
                    Name="Hat 2",
                    Description="This is a test description 13",
                    Price=800,
                    PictureURL="/images/products/hat-react1.png",
                    Brand="React",
                    Type="Hat",
                    QuantityInStock=1500
                },
                new Product{
                    Name="Hat 3",
                    Description="This is a test description 14",
                    Price=900,
                    PictureURL="/images/products/hat-react2.png",
                    Brand="React",
                    Type="Hat",
                    QuantityInStock=150
                },
                new Product{
                    Name="Board 3",
                    Description="This is a test description 15",
                    Price=3500,
                    PictureURL="/images/products/sb-core1.png",
                    Brand="Core",
                    Type="Board",
                    QuantityInStock=100
                },
                new Product{
                    Name="Board 4",
                    Description="This is a test description 16",
                    Price=3500,
                    PictureURL="/images/products/sb-core2.png",
                    Brand="Core",
                    Type="Board",
                    QuantityInStock=40
                },
                new Product{
                    Name="Board 5",
                    Description="This is a test description 17",
                    Price=3200,
                    PictureURL="/images/products/sb-react1.png",
                    Brand="React",
                    Type="Board",
                    QuantityInStock=65
                },
                new Product{
                    Name="Board 6",
                    Description="This is a test description 18",
                    Price=4000,
                    PictureURL="/images/products/sb-ts1.png",
                    Brand="TS",
                    Type="Board",
                    QuantityInStock=10
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