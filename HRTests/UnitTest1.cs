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
            DataManager dataManager = new DataManager();
            List<Person> expectedPersons = dataManager.GetJsonData();

            //Act
            List<Person> actualPersons = HRManager.GetAllPersons();

            //Assert
            Assert.Equal(expectedPersons, actualPersons);


        }
    }
}