using Tyuiu.AkopovaLV.Sprint3.Task1.V4.Lib;
namespace Tyuiu.AkopovaLV.Sprint3.Task1.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;
            double res = ds.GetSumSeries(startValue, stopValue);
            double wait = 1.55;
            Assert.AreEqual(wait, res);
        }
    }
}
