namespace ProductLib
{
    public class ProductManager
    {
        public Product GetProduct(int id)
        {
            Product product=new Product{ Id=1,Name="Rose",Description="beautiful flower",UnitPrice=20};
            return product;
        }
    }
}
