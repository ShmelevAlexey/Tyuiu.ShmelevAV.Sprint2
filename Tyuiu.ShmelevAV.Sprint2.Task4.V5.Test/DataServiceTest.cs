using Tyuiu.ShmelevAV.Sprint2.Task4.V5.Lib;

namespace Tyuiu.ShmelevAV.Sprint2.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 11;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 89.608;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 6;
            double res = ds.Calculate(x, y);
            double wait = 200.167;
            Assert.AreEqual(wait, res);
        }
    }
}