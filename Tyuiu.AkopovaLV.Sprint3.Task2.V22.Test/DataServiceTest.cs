using Tyuiu.AkopovaLV.Sprint3.Task2.V22.Lib;
namespace Tyuiu.AkopovaLV.Sprint3.Task2.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 5;
            int stValue = 1;
            int enValue = 7;
            var res = ds.GetMultiplySeries(value, stValue, enValue);
            double wait = 0.125;
            Assert.AreEqual(wait, res);

        }
    }
}
