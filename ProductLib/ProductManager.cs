namespace ProductLib
{
    public class ProductManager
    {
        public static List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "Rose", Description = "beautiful flower", UnitPrice = 25 });
            products.Add(new Product { Id = 2, Name = "Jasmine", Description = "red flower", UnitPrice = 60});
            products.Add(new Product { Id = 3, Name = "Lily", Description = "awesome flower", UnitPrice = 30 });
            products.Add(new Product { Id = 4, Name = "Sunflower", Description = "yello flower", UnitPrice = 35});
            return products;
        }
        public static Product GetProduct()
        {
            Product product=new Product{ Id=1,Name="Rose",Description="beautiful flower",UnitPrice=20};
            return product;
        }
    }
}
