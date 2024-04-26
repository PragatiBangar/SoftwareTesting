using QuestionBankTest.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionBankEntities;
using System.Text.Json;


namespace QuestionBankTest
{
    public class QuestionTest
    {
        private readonly HttpClient _httpClient;
        private string BaseUrl = "https://localhost:7104/api/questionbank/questions";

        public QuestionTest()
        {
            _httpClient = new HttpClient();
        }

        [Fact]
        public async Task QuestionBankTestAsync()
        {
            //Arrange
            List<QuestionTitle> expectedquestions = QuestionBankManager.ReadJSONSampleData();

            var response = await _httpClient.GetAsync(BaseUrl);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            List<QuestionTitle> resultProducts = JsonSerializer.Deserialize<List<QuestionTitle>>(content);

            Assert.Equal(expectedquestions, resultProducts);
        }
    }
}

