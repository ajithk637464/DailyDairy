using DailyDairy.Models;

namespace DailyDairy.Data
{
    public class AppState : IAppState
    {
        //public Dictionary<DateTime, List<Product>>? Products { get; set; } = new Dictionary<DateTime, List<Product>>();
        public Dictionary<DateTime, List<Product>> Products { get; set; } = new Dictionary<DateTime, List<Product>>()
        {
            {
                DateTime.Now,
                new List<Product>
                {
                    new Product
                    {
                        Id = 1,
                        ProductName = "Laptop",
                        ProductDescription = "14-inch, 8GB RAM, 256GB SSD, Windows 10 laptop.",
                        ProductPrice = 799.99m,
                        ProductCategory = Category.Electronics,
                        IsNecessary = true,
                        PurchaseDate = new DateTime(2024, 11, 15),
                        ProductPurchaseMode = PurchaseMode.Online,
                    },
                    new Product
                    {
                        Id = 2,
                        ProductName = "Smartphone",
                        ProductDescription = "6.5-inch display, 128GB storage, dual SIM, Android.",
                        ProductPrice = 499.99m,
                        ProductCategory = Category.Electronics,
                        IsNecessary = true,
                        PurchaseDate = new DateTime(2024, 11, 20),
                        ProductPurchaseMode = PurchaseMode.Online,
                    },
                    new Product
                    {
                        Id = 3,
                        ProductName = "Bluetooth Headphones",
                        ProductDescription = "Wireless over-ear headphones with noise cancellation.",
                        ProductPrice = 199.99m,
                        ProductCategory = Category.Electronics,
                        IsNecessary = false,
                        PurchaseDate = new DateTime(2024, 11, 10),
                        ProductPurchaseMode = PurchaseMode.Online,
                    },
                    new Product
                    {
                        Id = 4,
                        ProductName = "Office Chair",
                        ProductDescription = "Ergonomic office chair with lumbar support.",
                        ProductPrice = 129.99m,
                        ProductCategory = Category.Furniture,
                        IsNecessary = true,
                        PurchaseDate = new DateTime(2024, 10, 25),
                        ProductPurchaseMode = PurchaseMode.Offline,
                    },
                    new Product
                    {
                        Id = 5,
                        ProductName = "Microwave Oven",
                        ProductDescription = "Compact microwave oven, 700W, 20L capacity.",
                        ProductPrice = 89.99m,
                        ProductCategory = Category.Appliances,
                        IsNecessary = true,
                        PurchaseDate = new DateTime(2024, 10, 15),
                        ProductPurchaseMode = PurchaseMode.Online,
                    },
                    new Product
                    {
                        Id = 6,
                        ProductName = "Electric Kettle",
                        ProductDescription = "1.5L, stainless steel, automatic shut-off.",
                        ProductPrice = 29.99m,
                        ProductCategory = Category.Appliances,
                        IsNecessary = true,
                        PurchaseDate = new DateTime(2024, 11, 05),
                        ProductPurchaseMode = PurchaseMode.Offline,
                    },
                    new Product
                    {
                        Id = 7,
                        ProductName = "Bookshelf",
                        ProductDescription = "Wooden 5-tier bookshelf, walnut finish.",
                        ProductPrice = 149.99m,
                        ProductCategory = Category.Furniture,
                        IsNecessary = true,
                        PurchaseDate = new DateTime(2024, 09, 20),
                        ProductPurchaseMode = PurchaseMode.Online,
                    },
                    new Product
                    {
                        Id = 8,
                        ProductName = "Running Shoes",
                        ProductDescription = "Lightweight running shoes, size 10, breathable mesh.",
                        ProductPrice = 59.99m,
                        ProductCategory = Category.Clothing,
                        IsNecessary = true,
                        PurchaseDate = new DateTime(2024, 11, 18),
                        ProductPurchaseMode = PurchaseMode.Offline,
                    },
                    new Product
                    {
                        Id = 9,
                        ProductName = "Wireless Keyboard",
                        ProductDescription = "Compact wireless keyboard with rechargeable battery.",
                        ProductPrice = 39.99m,
                        ProductCategory = Category.Electronics,
                        IsNecessary = true,
                        PurchaseDate = new DateTime(2024, 11, 19),
                        ProductPurchaseMode = PurchaseMode.Online,
                    },
                    new Product
                    {
                        Id = 10,
                        ProductName = "Yoga Mat",
                        ProductDescription = "Non-slip yoga mat, 6mm thickness, eco-friendly material.",
                        ProductPrice = 24.99m,
                        ProductCategory = Category.Sports,
                        IsNecessary = true,
                        PurchaseDate = new DateTime(2024, 11, 22),
                        ProductPurchaseMode = PurchaseMode.Online,
                    }
                }



            },
            {
                new DateTime(2024,12,09),
                new List<Product>
                {
                    new Product
                    {
                        Id = 1,
                        ProductName = "Laptop",
                        ProductDescription = "14-inch, 8GB RAM, 256GB SSD, Windows 10 laptop.",
                        ProductPrice = 799.99m,
                        ProductCategory = Category.Electronics,
                        IsNecessary = true,
                        PurchaseDate = new DateTime(2024, 11, 15),
                        ProductPurchaseMode = PurchaseMode.Online,
                    },
                    new Product
                    {
                        Id = 2,
                        ProductName = "Smartphone",
                        ProductDescription = "6.5-inch display, 128GB storage, dual SIM, Android.",
                        ProductPrice = 499.99m,
                        ProductCategory = Category.Electronics,
                        IsNecessary = true,
                        PurchaseDate = new DateTime(2024, 11, 20),
                        ProductPurchaseMode = PurchaseMode.Online,
                    },
                    new Product
                    {
                        Id = 3,
                        ProductName = "Bluetooth Headphones",
                        ProductDescription = "Wireless over-ear headphones with noise cancellation.",
                        ProductPrice = 199.99m,
                        ProductCategory = Category.Electronics,
                        IsNecessary = false,
                        PurchaseDate = new DateTime(2024, 11, 10),
                        ProductPurchaseMode = PurchaseMode.Online,
                    },
                    new Product
                    {
                        Id = 4,
                        ProductName = "Office Chair",
                        ProductDescription = "Ergonomic office chair with lumbar support.",
                        ProductPrice = 129.99m,
                        ProductCategory = Category.Furniture,
                        IsNecessary = true,
                        PurchaseDate = new DateTime(2024, 10, 25),
                        ProductPurchaseMode = PurchaseMode.Offline,
                    },
                    new Product
                    {
                        Id = 5,
                        ProductName = "Microwave Oven",
                        ProductDescription = "Compact microwave oven, 700W, 20L capacity.",
                        ProductPrice = 89.99m,
                        ProductCategory = Category.Appliances,
                        IsNecessary = true,
                        PurchaseDate = new DateTime(2024, 10, 15),
                        ProductPurchaseMode = PurchaseMode.Online,
                    },
                    new Product
                    {
                        Id = 6,
                        ProductName = "Electric Kettle",
                        ProductDescription = "1.5L, stainless steel, automatic shut-off.",
                        ProductPrice = 29.99m,
                        ProductCategory = Category.Appliances,
                        IsNecessary = true,
                        PurchaseDate = new DateTime(2024, 11, 05),
                        ProductPurchaseMode = PurchaseMode.Offline,
                    },
                    new Product
                    {
                        Id = 7,
                        ProductName = "Bookshelf",
                        ProductDescription = "Wooden 5-tier bookshelf, walnut finish.",
                        ProductPrice = 149.99m,
                        ProductCategory = Category.Furniture,
                        IsNecessary = true,
                        PurchaseDate = new DateTime(2024, 09, 20),
                        ProductPurchaseMode = PurchaseMode.Online,
                    },
                    new Product
                    {
                        Id = 8,
                        ProductName = "Running Shoes",
                        ProductDescription = "Lightweight running shoes, size 10, breathable mesh.",
                        ProductPrice = 59.99m,
                        ProductCategory = Category.Clothing,
                        IsNecessary = true,
                        PurchaseDate = new DateTime(2024, 11, 18),
                        ProductPurchaseMode = PurchaseMode.Offline,
                    },
                    new Product
                    {
                        Id = 9,
                        ProductName = "Wireless Keyboard",
                        ProductDescription = "Compact wireless keyboard with rechargeable battery.",
                        ProductPrice = 39.99m,
                        ProductCategory = Category.Electronics,
                        IsNecessary = true,
                        PurchaseDate = new DateTime(2024, 11, 19),
                        ProductPurchaseMode = PurchaseMode.Online,
                    },
                    new Product
                    {
                        Id = 10,
                        ProductName = "Yoga Mat",
                        ProductDescription = "Non-slip yoga mat, 6mm thickness, eco-friendly material.",
                        ProductPrice = 24.99m,
                        ProductCategory = Category.Sports,
                        IsNecessary = true,
                        PurchaseDate = new DateTime(2024, 11, 22),
                        ProductPurchaseMode = PurchaseMode.Online,
                    }
                }



            },
            {
                new DateTime(2024,12,10),
                new List<Product>
                {
                    new Product
                    {
                        Id = 1,
                        ProductName = "Laptop",
                        ProductDescription = "14-inch, 8GB RAM, 256GB SSD, Windows 10 laptop.",
                        ProductPrice = 799.99m,
                        ProductCategory = Category.Electronics,
                        IsNecessary = true,
                        PurchaseDate = new DateTime(2024, 11, 15),
                        ProductPurchaseMode = PurchaseMode.Online,
                    },
                    new Product
                    {
                        Id = 2,
                        ProductName = "Smartphone",
                        ProductDescription = "6.5-inch display, 128GB storage, dual SIM, Android.",
                        ProductPrice = 499.99m,
                        ProductCategory = Category.Electronics,
                        IsNecessary = true,
                        PurchaseDate = new DateTime(2024, 11, 20),
                        ProductPurchaseMode = PurchaseMode.Online,
                    },
                    new Product
                    {
                        Id = 3,
                        ProductName = "Bluetooth Headphones",
                        ProductDescription = "Wireless over-ear headphones with noise cancellation.",
                        ProductPrice = 199.99m,
                        ProductCategory = Category.Electronics,
                        IsNecessary = false,
                        PurchaseDate = new DateTime(2024, 11, 10),
                        ProductPurchaseMode = PurchaseMode.Online,
                    },
                    new Product
                    {
                        Id = 4,
                        ProductName = "Office Chair",
                        ProductDescription = "Ergonomic office chair with lumbar support.",
                        ProductPrice = 129.99m,
                        ProductCategory = Category.Furniture,
                        IsNecessary = true,
                        PurchaseDate = new DateTime(2024, 10, 25),
                        ProductPurchaseMode = PurchaseMode.Offline,
                    },
                    new Product
                    {
                        Id = 5,
                        ProductName = "Microwave Oven",
                        ProductDescription = "Compact microwave oven, 700W, 20L capacity.",
                        ProductPrice = 89.99m,
                        ProductCategory = Category.Appliances,
                        IsNecessary = true,
                        PurchaseDate = new DateTime(2024, 10, 15),
                        ProductPurchaseMode = PurchaseMode.Online,
                    },
                    new Product
                    {
                        Id = 6,
                        ProductName = "Electric Kettle",
                        ProductDescription = "1.5L, stainless steel, automatic shut-off.",
                        ProductPrice = 29.99m,
                        ProductCategory = Category.Appliances,
                        IsNecessary = true,
                        PurchaseDate = new DateTime(2024, 11, 05),
                        ProductPurchaseMode = PurchaseMode.Offline,
                    },
                    new Product
                    {
                        Id = 7,
                        ProductName = "Bookshelf",
                        ProductDescription = "Wooden 5-tier bookshelf, walnut finish.",
                        ProductPrice = 149.99m,
                        ProductCategory = Category.Furniture,
                        IsNecessary = true,
                        PurchaseDate = new DateTime(2024, 09, 20),
                        ProductPurchaseMode = PurchaseMode.Online,
                    },
                    new Product
                    {
                        Id = 8,
                        ProductName = "Running Shoes",
                        ProductDescription = "Lightweight running shoes, size 10, breathable mesh.",
                        ProductPrice = 59.99m,
                        ProductCategory = Category.Clothing,
                        IsNecessary = true,
                        PurchaseDate = new DateTime(2024, 11, 18),
                        ProductPurchaseMode = PurchaseMode.Offline,
                    },
                    new Product
                    {
                        Id = 9,
                        ProductName = "Wireless Keyboard",
                        ProductDescription = "Compact wireless keyboard with rechargeable battery.",
                        ProductPrice = 39.99m,
                        ProductCategory = Category.Electronics,
                        IsNecessary = true,
                        PurchaseDate = new DateTime(2024, 11, 19),
                        ProductPurchaseMode = PurchaseMode.Online,
                    },
                    new Product
                    {
                        Id = 10,
                        ProductName = "Yoga Mat",
                        ProductDescription = "Non-slip yoga mat, 6mm thickness, eco-friendly material.",
                        ProductPrice = 24.99m,
                        ProductCategory = Category.Sports,
                        IsNecessary = true,
                        PurchaseDate = new DateTime(2024, 11, 22),
                        ProductPurchaseMode = PurchaseMode.Online,
                    }
                }



            }

        };
    }
}
