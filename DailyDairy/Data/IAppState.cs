using DailyDairy.Models;

namespace DailyDairy.Data
{
    public interface IAppState
    {
        public List<Product>? Products { get; set; }
    }
}
