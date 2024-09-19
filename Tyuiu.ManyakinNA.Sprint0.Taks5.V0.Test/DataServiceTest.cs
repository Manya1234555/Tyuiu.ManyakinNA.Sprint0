using Tyuiu.ManyakinNA.Sprint0.Taks5.V0.Lib;

namespace Tyuiu.ManyakinNA.Sprint0.Taks5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionalValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));

        }
        [TestMethod]
        public void CheckedSubstractionValid()
        {
            Assert.AreEqual(5, DataService.Substraction(10, 5));
        }
        [TestMethod]
        public void CheckedMultiplicationlValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(5, 10));
        }
        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}