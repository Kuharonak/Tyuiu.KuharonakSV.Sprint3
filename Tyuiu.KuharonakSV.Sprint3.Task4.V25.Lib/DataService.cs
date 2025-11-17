using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KuharonakSV.Sprint3.Task4.V25.Lib
{
    public class DataService : ISprint3Task4V25
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            for (int x = startValue; x <= startValue; x++)
            {
                if (x == 0)
                {
                    continue;
                }
                else
                {
                    res = res + (x / (Math.Cos(x) - Math.Sin(x)));
                }
            }
            return Math.Round(res, 3);
        }
    }
}
