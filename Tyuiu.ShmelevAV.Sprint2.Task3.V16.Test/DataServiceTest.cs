using Tyuiu.ShmelevAV.Sprint2.Task3.V16.Lib;

namespace Tyuiu.ShmelevAV.Sprint2.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 29;
            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 128;
            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -21;
            double res = ds.Calculate(x);
            double wait = -230.952;
            Assert.AreEqual(res, wait);
        }
    }
}