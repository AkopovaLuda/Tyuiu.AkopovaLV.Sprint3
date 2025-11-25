using Tyuiu.AkopovaLV.Sprint3.Task6.V8.Lib;
namespace Tyuiu.AkopovaLV.Sprint3.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int stVal = 18;
            int enVal = 28;
            int res = ds.GetSumTheDivisors(stVal, enVal);
            int wait = 292;
            Assert.AreEqual(wait, res);
        }
    }
}
