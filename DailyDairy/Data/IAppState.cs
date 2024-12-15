using DailyDairy.Models;

namespace DailyDairy.Data
{
    public interface IAppState
    {
        public Dictionary<DateTime,List<Product>>? Products { get; set; }
    }
}
