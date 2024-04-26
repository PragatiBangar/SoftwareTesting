using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using QuestionBankEntities;

namespace QuestionBankTest.Utility
{
    public class QuestionBankManager
    {
        public static List<QuestionTitle> ReadJSONSampleData()
        {
            //Retrive data from sample given to testers
            //DeSerialization of data from people.json
            //Use File IO
            //Use JsonSerializer.Deserialize method
            //retrieve list of person data
            //return list of person data
            string fileName = @"C:/SoftwareTesting/TFLAssessment/QuestionBankTest/SampleData/questionbank.json";
            string jsonString = File.ReadAllText(fileName);
            List<QuestionTitle> jsonPeople = JsonSerializer.Deserialize<List<QuestionTitle>>(jsonString);
            return jsonPeople;
        }
    }
}
