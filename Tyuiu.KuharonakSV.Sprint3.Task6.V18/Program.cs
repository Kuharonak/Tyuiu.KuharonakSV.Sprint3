using Tyuiu.KuharonakSV.Sprint3.Task6.V18.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("* УСЛОВИЕ:                                                                *");

        Console.WriteLine("*Напишите программу, которая ищет среди целых чисел, принадлежащих числово*");
        Console.WriteLine("*ому отрезку [9, 18] сумму всех делителей меньше 10                       *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = 9;
        int stopValue = 18;

        Console.WriteLine("Начало отрезка = " + startValue);
        Console.WriteLine("Конец отрезка = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        

        var result = ds.GetSumTheDivisors(startValue, stopValue);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}