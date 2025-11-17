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

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);
            double wait = 7.405;

            Assert.AreEqual(wait, res);
        }
    }
}
