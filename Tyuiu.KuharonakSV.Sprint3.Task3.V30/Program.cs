using Tyuiu.KuharonakSV.Sprint3.Task3.V30.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Кухаронак  С В | СМАРТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема:  Оператор цикла foreach                                           *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #30                                                             *");
        Console.WriteLine("* Выполнил: Кухаронак С В | СМАРТБ-25-1                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Используя цикл foreach подсчитать максимальное количество букв y,       *");
        Console.WriteLine("*  находящихся на соседних позициях в строке: fyyklbtyn ygrc vfyyyyh      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Исходные данные:                                                        *");
        Console.WriteLine("***************************************************************************");

        string value = "fyyklbtyn ygrc vfyyyyh";
        char item = 'y';
        Console.WriteLine("Исходная строка = " + value);
        Console.WriteLine("Искомый символ " + item);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.GetMaxCharCount(value, item);
        Console.WriteLine(res);
        Console.ReadLine();
    }
}