using Tyuiu.KuharonakSV.Sprint3.Task4.V25.Lib;
namespace Tyuiu.KuharonakSV.Sprint3.Task4.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            Assert.That(ds.Calculate(-5, -1), Is.EqualTo(8.995));
        }
    }
}
