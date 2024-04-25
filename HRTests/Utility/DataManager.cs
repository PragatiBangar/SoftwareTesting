using System.Net.Http.Headers;
using System.Text.Json;
using HR.Entities;
namespace HR
{
    public class DataManager
    {
        public DataManager()
        {

        }
        public static bool SetJsonData()
        {
            bool status = false;
            List<Person> people =new List<Person>();
            people.Add(new Person { Id=6,Name="Nutan",Age=30});
            people.Add(new Person { Id = 7, Name = "Tejal", Age = 24 });

            string fileName = @"C:/XUnitTestProject/SoftwareTesting/HRTests/SampleData/people.json";
            var options=new JsonSerializerOptions { IncludeFields = true };
            var jsonPeople = JsonSerializer.Serialize<List<Person>>(people,options);
            File.WriteAllText(fileName, jsonPeople);
            status = true;
            return status;
        }

        public static List<Person> GetJsonData()
        {
            string fileName = @"C:/XUnitTestProject/SoftwareTesting/HRTests/SampleData/people.json";
            string jsonString = File.ReadAllText(fileName);
            List<Person> jsonPeople = JsonSerializer.Deserialize<List<Person>>(jsonString);
            return jsonPeople;
        }


        
    }
}
