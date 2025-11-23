using Tyuiu.KuharonakSV.Sprint3.Task6.V18.Lib;
namespace Tyuiu.KuharonakSV.Sprint3.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 9;
            int stopValue = 18;

            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 95;

            Assert.AreEqual(wait, res);
        }
    }
}
