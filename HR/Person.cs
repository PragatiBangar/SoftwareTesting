using System.Net.Http.Headers;

namespace HR.Entities
{
    [Serializable]
    public class Person:IComparable
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(object? obj)
        {
            Person secondPerson = obj as Person;
            return secondPerson.Name.CompareTo(Name);
        }
    }
}
