
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
        [Route("GetAllProducts/{date:Datetime}")]
        public ActionResult<List<Product>> GetAllProducts(DateTime date)
        {
            try
            {
                List<Product> productsForDate = new();
                string RequestDate = date.ToString("yyyy-MM-dd");
                foreach (var entry in _appState.Products)
                {
                    string DictDate = entry.Key.ToString("yyyy-MM-dd");
                    if (DictDate == RequestDate)
                    {
                        productsForDate.AddRange(entry.Value);
                    }
                }

                return Ok(productsForDate);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        //        [HttpPut]
        //        [Route("AddProduct")]
        //        public ActionResult<Task> AddProduct([FromBody]Product product)
        //        {
        //            //if (product != null)
        //            //{ 
        //            //    _appState?.Products?.Add(product);
        //            //    return Ok("Product Added successfully");
        //            //}
        //            //return BadRequest();
        //        }
        //        [HttpDelete]
        //[Route("DeleteProduct/{productId:int}")]
        //        public ActionResult<Task> DeleteProduct(int productId)
        //        {
        //            var deleteProduct = _appState?.Products?.Find(x => x.Id == productId);
        //            if (deleteProduct != null)
        //            {
        //                _appState?.Products?.Remove(deleteProduct);
        //            }
        //            return Ok("Product Deleted successfully");
        //        }
    }
    
}
