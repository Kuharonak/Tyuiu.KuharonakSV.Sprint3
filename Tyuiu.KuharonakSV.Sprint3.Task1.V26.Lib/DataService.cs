using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KuharonakSV.Sprint3.Task1.V26.Lib
{
    public class DataService : ISprint3Task1V26
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double multseries = 1;
            while (startValue < stopValue)
            { 
                multseries  = multseries + (Math.Pow(6/Math.Pow(value, startValue), 2));
                return Math.Round(multseries, 3);
            }
        }
    }
}
