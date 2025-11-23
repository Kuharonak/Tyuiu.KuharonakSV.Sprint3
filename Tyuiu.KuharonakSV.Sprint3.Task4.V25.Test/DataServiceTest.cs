using Tyuiu.KuharonakSV.Sprint3.Task4.V25.Lib;
namespace Tyuiu.KuharonakSV.Sprint3.Task4.V25.Test
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        DataService ds = new DataService();
        Assert.That(ds.Calculate(-5, -1), Is.EqualTo(8.995));
    }
}
}
