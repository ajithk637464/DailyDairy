using Microsoft.AspNetCore.Components.Forms;

namespace DailyDairy.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public string ProductDescription { get; set; } = string.Empty;
        public decimal? ProductPrice { get; set; }
        public Category? ProductCategory { get; set; }
        public bool? IsNecessary { get; set; }
        public bool IsUsed { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public PurchaseMode ProductPurchaseMode { get; set; }
        public IBrowserFile? bill {  get; set; }
    }
    public enum Category
    {
        Electronics,
        Clothing,
        HomeGoods,
        Beauty,
        Books,
        Toys,
        Food,
        Sports,
        Automotive,
        Pets,
        Snakes,  
        Gardening, 
        Furniture,
        Music, 
        Movies 
    }
    public enum PurchaseMode
    {
        Online,
        Offline
    }
}
