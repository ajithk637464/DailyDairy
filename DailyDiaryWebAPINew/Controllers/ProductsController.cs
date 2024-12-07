
using DailyDairy.Data;
using DailyDairy.Models;
using Microsoft.AspNetCore.Mvc;

namespace DailyDiaryWebAPINew.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IAppState _appState;
        public ProductsController(IAppState appState)
        {
            _appState = appState;
        }
        [HttpGet]
        [Route("GetAllProducts")]
        public ActionResult<List<Product>> GetAllProducts()
        { 
           return Ok(_appState.Products);
        }
        [HttpPut]
        [Route("AddProduct")]
        public ActionResult<Task> AddProduct([FromBody]Product product)
        {
            if (product != null)
            { 
                _appState?.Products?.Add(product);
                return Ok("Product Added successfully");
            }
            return BadRequest();
        }
        [HttpDelete]
        [Route("DeleteProduct/{id:int}")]
        public ActionResult<Task> DeleteProduct(int productId)
        {
            var deleteProduct = _appState?.Products?.Find(x => x.Id == productId);
            if (deleteProduct != null)
            {
                _appState?.Products?.Remove(deleteProduct);
            }
            return Ok("Product Deleted successfully");
        }
    }
    
}
