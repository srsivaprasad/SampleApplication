using Newtonsoft.Json;

namespace IRISTest
{
    public class Task4 
    {
        public static List<SoftwareProduct> GetSoftwareProducts(string apiUrl)
        {
            SoftwareProductService softwareProductService = new SoftwareProductService();
            return softwareProductService.GetSoftwareProductsAsync(apiUrl).Result;
        }
    }
    public class SoftwareProductService
    {
        internal async Task<List<SoftwareProduct>> GetSoftwareProductsAsync(string apiUrl)
        {
            try
            {
                HttpClient _httpClient = new HttpClient();
                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                string responseContent = await response.Content.ReadAsStringAsync();
                List<SoftwareProduct> products = JsonConvert.DeserializeObject<List<SoftwareProduct>>(responseContent);
                return products;
            }
            catch (Exception e)
            {
                Console.WriteLine($"error: {e.Message}");
                throw;
            }
        }

        // Other methodes related to SoftwareProductService
    }
    public class SoftwareProduct
    {
        public string Name { get; set; }
        public string Version { get; set; }
    }
}
