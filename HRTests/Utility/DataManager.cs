using System.Text.Json;
using HR.Entities;
namespace HR
{
    public class DataManager
    {
        public List<Person> GetJsonData()
        {
            string fileName = @"C:/SoftwareTesting/TestPracticeApp/SoftwareTesting/HRTests/SampleData/people.json";
            string jsonString = File.ReadAllText(fileName);
            List<Person> jsonPeople = JsonSerializer.Deserialize<List<Person>>(jsonString);
            return jsonPeople;
        }

    }
}
