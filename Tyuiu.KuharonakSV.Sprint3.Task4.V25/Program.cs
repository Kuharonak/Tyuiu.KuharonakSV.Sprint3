using Tyuiu.KuharonakSV.Sprint3.Task4.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Кухаронак С В | СМАРТБ-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #25                                                             *");
        Console.WriteLine("* Выполнил: Кухаронак С В | СМАРТБ-25-1                                   *");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
        Console.WriteLine("* функции y=x/(cos(x)-sin(x)) При х = 0 пропустить значение. Полученные   *");
        Console.WriteLine("* значения суммировать.                                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите x: ");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите y: ");
        int stop = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(start, stop));
        Console.ReadKey();
    }
}