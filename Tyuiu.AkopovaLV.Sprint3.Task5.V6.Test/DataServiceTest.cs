using Tyuiu.AkopovaLV.Sprint3.Task5.V6.Lib;
namespace Tyuiu.AkopovaLV.Sprint3.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int stVal1 = 1;
            int stVal2 = 1;
            int enVal1 = 3;
            int enVal2 = 10;
            var res = ds.GetSumSumSeries(stVal1, stVal2, enVal1, enVal2);
            double wait = 40.917;
            Assert.AreEqual(wait, res);

        }
    }
}
