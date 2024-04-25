using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace ProductLib
{
    [Serializable]
    public class Product:IComparable
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("unitprice")]
        public int UnitPrice { get; set; }

        public int CompareTo(object? obj)
        {
            Product secondProduct = obj as Product;   
            return secondProduct.Name.CompareTo(Name);
        }
    }
}
