using System.Xml.Linq;

namespace ProductLib
{
    public class Product:IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int UnitPrice { get; set; }

        public int CompareTo(object? obj)
        {
            Product secondProduct = obj as Product;   
            return secondProduct.Name.CompareTo(Name);
        }
    }
}
