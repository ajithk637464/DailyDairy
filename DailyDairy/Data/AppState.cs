using DailyDairy.Models;

namespace DailyDairy.Data
{
    public class AppState : IAppState
    {
        //public Dictionary<DateTime, List<Product>>? Products { get; set; } = new Dictionary<DateTime, List<Product>>();
        List<Product> IAppState.Products { get; set; } = new List<Product>()
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
                bill = null
            },
            new Product
            {
                Id = 2,
                ProductName = "Running Shoes",
                ProductDescription = "Men's athletic shoes with breathable mesh and cushioned sole.",
                ProductPrice = 69.99m,
                ProductCategory = Category.Sports,
                IsNecessary = true,
                PurchaseDate = new DateTime(2024, 11, 12),
                ProductPurchaseMode = PurchaseMode.Online,
                bill = null
            },
            new Product
            {
                Id = 3,
                ProductName = "Smartphone",
                ProductDescription = "5G-ready smartphone with 128GB storage and 6GB RAM.",
                ProductPrice = 499.99m,
                ProductCategory = Category.Sports,
                IsNecessary = true,
                PurchaseDate = new DateTime(2024, 10, 5),
                ProductPurchaseMode = PurchaseMode.Offline,
                bill = null
            },
            new Product
            {
                Id = 4,
                ProductName = "Organic Avocados",
                ProductDescription = "Pack of 3 organic avocados, sourced from local farms.",
                ProductPrice = 5.49m,
                ProductCategory = Category.Sports,
                IsNecessary = true,
                PurchaseDate = new DateTime(2024, 11, 10),
                ProductPurchaseMode = PurchaseMode.Offline,
                bill = null
            },
            new Product
            {
                Id = 5,
                ProductName = "Yoga Mat",
                ProductDescription = "Non-slip yoga mat with carrying strap.",
                ProductPrice = 19.99m,
                ProductCategory = Category.Sports,
                IsNecessary = false,
                PurchaseDate = new DateTime(2024, 9, 20),
                ProductPurchaseMode = PurchaseMode.Online,
                bill = null
            },
            new Product
            {
                Id = 6,
                ProductName = "Pet Snake (Ball Python)",
                ProductDescription = "Healthy ball python, including a starter kit.",
                ProductPrice = 120.00m,
                ProductCategory = Category.Sports,
                IsNecessary = false,
                PurchaseDate = new DateTime(2024, 7, 30),
                ProductPurchaseMode = PurchaseMode.Online,
                bill = null
            },
            new Product
            {
                Id = 7,
                ProductName = "Garden Shovel",
                ProductDescription = "Sturdy garden shovel with ergonomic handle.",
                ProductPrice = 25.99m,
                ProductCategory = Category.Sports,
                IsNecessary = false,
                PurchaseDate = new DateTime(2024, 6, 18),
                ProductPurchaseMode = PurchaseMode.Offline,
                bill = null
            },
            new Product
            {
                Id = 8,
                ProductName = "Electric Kettle",
                ProductDescription = "1.5L electric kettle with fast boil technology.",
                ProductPrice = 34.99m,
                ProductCategory = Category.Sports,
                IsNecessary = true,
                PurchaseDate = new DateTime(2024, 10, 3),
                ProductPurchaseMode = PurchaseMode.Online,
                bill = null
            },
            new Product
            {
                Id = 9,
                ProductName = "Bluetooth Speaker",
                ProductDescription = "Portable wireless Bluetooth speaker with 12-hour battery life.",
                ProductPrice = 45.99m,
                ProductCategory = Category.Sports,
                IsNecessary = false,
                PurchaseDate = new DateTime(2024, 8, 25),
                ProductPurchaseMode = PurchaseMode.Offline,
                bill = null
            },
            new Product
            {
                Id = 10,
                ProductName = "Office Chair",
                ProductDescription = "Ergonomic office chair with lumbar support.",
                ProductPrice = 149.99m,
                ProductCategory = Category.Sports,
                IsNecessary = true,
                PurchaseDate = new DateTime(2024, 9, 10),
                ProductPurchaseMode = PurchaseMode.Online,
                bill = null
            }
        };
    }
}
