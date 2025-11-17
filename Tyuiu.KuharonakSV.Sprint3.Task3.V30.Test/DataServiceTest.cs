using Tyuiu.KuharonakSV.Sprint3.Task3.V30.Lib;
namespace Tyuiu.KuharonakSV.Sprint3.Task3.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMaxCharCount()
        {
            DataService ds = new DataService();

            string value = "fyyklbtyn ygrc vfyyyyh";
            char item = 'y';

            int res = ds.GetMaxCharCount(value, item);

            int wait = 4;

            Assert.AreEqual(wait, res);
        }
    }
}
