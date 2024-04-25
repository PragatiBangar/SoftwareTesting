using ProductLib;

namespace ProductXUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Product expectedResult = new Product { Id = 1, Name = "Rose", Description = "beautiful flower", UnitPrice = 20 };
            int id = 23;

            //Act
            Product actualResult = ProductManager.GetProduct();

            //Assert
            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public void Test2()
        {

        }
    }
}