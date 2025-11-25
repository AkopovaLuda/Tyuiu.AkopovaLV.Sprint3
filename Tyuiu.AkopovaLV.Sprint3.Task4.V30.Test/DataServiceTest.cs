using Tyuiu.AkopovaLV.Sprint3.Task4.V30.Lib;
namespace Tyuiu.AkopovaLV.Sprint3.Task4.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int stValue = -5;
            int nwValue = 5;
            var res = ds.Calculate(stValue, nwValue);
            double wait = 1.924;
            Assert.AreEqual(wait, res);
        }
    }
}
