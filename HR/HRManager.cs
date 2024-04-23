using HR.Entities;
namespace HR
{
    public class HRManager
    {
        public HRManager() { }

        public static List<Person> GetAllPersons()
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person { Id = 1, Name = "Pragati", Age = 23 });
            persons.Add(new Person { Id = 2, Name = "Akash", Age = 23 });
            persons.Add(new Person { Id = 3, Name = "Neha", Age = 23 });
            persons.Add(new Person { Id = 4, Name = "Ajinkya", Age = 23 });
            persons.Add(new Person { Id = 5, Name = "Rutuja", Age = 23 });
            return persons;
        }

    }
}
