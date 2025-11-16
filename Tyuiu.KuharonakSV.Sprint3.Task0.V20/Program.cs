using Tyuiu.KuharonakSV.Sprint3.Task0.V20.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2| Выполнил:  Кухаронак С В| СМАРТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #20                                                             *");
        Console.WriteLine("* Выполнил: |   Кухаронак С В                                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* вычисляет, и печатает результат на экране                               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Исходные данные                                                         *");
        Console.WriteLine("***************************************************************************");
        int value = 1;
        int startValue = 1;
        int stopValue = 14;
        Console.WriteLine("Переменная x = " + value);
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);
        Console.WriteLine("********************************************************************************");
        Console.WriteLine("* Результат:                                                                   *");
        Console.WriteLine("********************************************************************************");
        Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
        Console.ReadKey();
    }
}