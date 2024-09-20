using Tyuiu.GulienkoPO.Sprint0.Task4.V0.lib;

namespace Tyuiu.GulienkoPO.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
    }
}