using QuestionBankTest.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionBankEntities;
using System.Text.Json;

namespace QuestionBankTest.Tests.ControllerTests
{
    public class QuestionBankControllerTests
    {
        private readonly HttpClient _httpClient;
        private string BaseUrl = "http://localhost:7104/api/questionbank/questions";

        public QuestionBankControllerTests()
        {
                _httpClient = new HttpClient();
        }

        [Fact]
        public async Task QuestionBankTestAsync()
        {
            //Arrange
            List<QuestionTitle> expectedquestions=QuestionBankManager.ReadJSONSampleData();


            var response = await _httpClient.GetAsync(BaseUrl);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            List<QuestionTitle> resultProducts = JsonSerializer.Deserialize<List<QuestionTitle>>(content);

            Assert.Equal(expectedquestions, resultProducts);
        }
    }
}
