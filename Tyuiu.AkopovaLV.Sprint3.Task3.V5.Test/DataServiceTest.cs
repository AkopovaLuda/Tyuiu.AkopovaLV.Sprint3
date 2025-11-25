using Tyuiu.AkopovaLV.Sprint3.Task3.V5.Lib;
namespace Tyuiu.AkopovaLV.Sprint3.Task3.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            char old = 'a';
            char nev = '*';
            string value = "fifa al fall";
            string res = ds.ReplaceCharInString(value, old, nev);
            string wait = "fif* *l f*ll";
            Assert.AreEqual(wait, res);
        }
    }
}
