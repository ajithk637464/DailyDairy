namespace DailyDairy.Models
{
    public class ShopDetails
    {
        public int ShopId { get; set; }
        public string? ShopName { get; set; }
        public ShopAddress? ShopAddressDetails { get; set; }
        public int Rating { get; set; }


    }
    public class ShopAddress
    { 
        public string? StreetName { get; set; }
        public string? City { get; set; }
        public string? PinCode { get; set; }
    }
}
