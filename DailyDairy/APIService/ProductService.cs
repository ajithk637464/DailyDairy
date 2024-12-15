using System.Net;
using System.Net.Http;
using System.Text.Json;
using DailyDairy.Models;
using static System.Net.WebRequestMethods;

namespace DailyDairy.APIService
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }   
        public async Task<List<Product>> GetAllProducts(DateTime? date)
        {
            try
            {
                var formattedDate = date?.ToString("yyyy-MM-dd");
                var products = await _httpClient.GetFromJsonAsync<List<Product>>($"Products/GetAllProducts/{formattedDate}");
                return products; // If successful, return the products
            }
            catch (Exception e) 
            {
                return null; 
            }
        }
        //public async Task DeleteProduct(int productId)
        //{
        //    var response = await _httpClient.DeleteAsync($"Products/DeleteProduct/{productId}");

        //}
    }
}
