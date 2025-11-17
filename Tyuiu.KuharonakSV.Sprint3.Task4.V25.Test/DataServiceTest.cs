using Tyuiu.KuharonakSV.Sprint3.Task4.V25.Lib;
namespace Tyuiu.KuharonakSV.Sprint3.Task4.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startVal = -5;
            int stopVal = 5;

            double res = ds.Calculate(startVal, stopVal);

            double wait = 44.313;
            Assert.AreEqual(wait, res);
        }
    }
}
