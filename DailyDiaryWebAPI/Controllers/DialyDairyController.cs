using ShareModel;
using Microsoft.AspNetCore.Mvc;
using DailyDairy.Data;
using DailyDairy.Models;
namespace DailyDiaryWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DialyDairyController : Controller
    {
        [HttpGet]
        [Route("/GetAllTasks")]
        public ActionResult<List<Product>> GetAllTasks()
        {
            return AppState.Products;
        }
    }
}
