using CalculatorLib;
using ProductLib;
using System.Xml.Linq;
namespace CalculatorXUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int expectedResult = 5;

            //Act
            int actualResult =calculator.Addition(2,3);

            //Assert
            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public async void Test2()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int expectedResult = 5;

            //Act
            int actualResult = await calculator.Substraction(10,5);

            //Assert
            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public void Test3() {
            //Arrange
            Calculator calculator = new Calculator();
            int expectedResult = 25;

            //Act
            int actualResult = calculator.Multiplication(5,5);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Test4()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int expectedResult = 5;

            //Act
            int actualResult = calculator.Division(25, 5);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Test5()
        {
            //Arrange
            
            Product expectedResult = new Product { Id = 1, Name = "Rose", Description = "beautiful flower", UnitPrice = 20 };
            

            //Act
            Product actualResult = ProductManager.GetProduct();

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}