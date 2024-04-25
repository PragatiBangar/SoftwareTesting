using HR;
using HR.Entities;
namespace HRTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            
            List<Person> expectedPersons = DataManager.GetJsonData();

            //Act
            List<Person> actualPersons = HRManager.GetAllPersons();

            //Assert
            Assert.Equal(expectedPersons, actualPersons);


        }

        [Fact]
        public void Test2()
        {

            //Arrange
            bool expectedResult = true;

            //Act
            
            bool actualResult = DataManager.SetJsonData();

            //Assert
            Assert.Equal(expectedResult, actualResult);


        }
    }
}