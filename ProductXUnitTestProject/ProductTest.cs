using ProductLib;
using System.Text.Json;


namespace ProductXUnitTestProject
{
    public class ProductTest
    {
        private const string BaseUrl = "https://localhost:7050/products";
        private readonly HttpClient _httpClient;

        public ProductTest()
        {
            _httpClient = new HttpClient();
        }

        [Fact]
        public void Test1()
        {
            Product expectedResult = new Product { Id = 1, Name = "Rose", Description = "beautiful flower", UnitPrice = 20 };
            int id = 23;

            //Act
            Product actualResult = ProductManager.GetProduct();

            //Assert
            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public async Task Get_ReturnsCorrectResponse()
        {
            //Arrange
            List<Product> expectedProducts = new List<Product>();
            expectedProducts.Add(new Product { Id = 1, Name = "Rose", Description = "beautiful flower", UnitPrice = 25 });
            expectedProducts.Add(new Product { Id = 2, Name = "Jasmine", Description = "red flower", UnitPrice = 60 });
            expectedProducts.Add(new Product { Id = 3, Name = "Lily", Description = "awesome flower", UnitPrice = 30 });
            expectedProducts.Add(new Product { Id = 4, Name = "Sunflower", Description = "yello flower", UnitPrice = 35 });
            //Act
            var response=await _httpClient.GetAsync(BaseUrl);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            List<Product> resultProducts = JsonSerializer.Deserialize<List<Product>>(content);

            //Assert
            Assert.Equal(expectedProducts, resultProducts);
        }
    }
}