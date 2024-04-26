using QuestionBankEntities;
using System.Data;
using MySql.Data.MySqlClient;

namespace QuestionBank.Services
{
    public class QuestionBankService
    {
        private string connectionString = "server=localhost;port=3306;user=root;password=password;database=assessmentdb";

        public List<QuestionTitle> GetAllQuestions()
        {
            List<QuestionTitle> questions = new List<QuestionTitle>();
            string query = @"select * from questionbank";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string title = reader["title"].ToString();

                    QuestionTitle question = new QuestionTitle();
                    question.id = id;
                    question.title = title;

                    questions.Add(question);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return questions;
        }
    }
}
