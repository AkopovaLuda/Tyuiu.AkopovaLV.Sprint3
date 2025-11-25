using tyuiu.cources.programming.interfaces.Sprint3;
using Tyuiu.AkopovaLV.Sprint3.Task0.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнила: Акопова Л. В. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Оператор цикла for                                                      *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("* Выполнила: Акопова Людмила Владимировна | АСОиУб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");

        Console.WriteLine("*Написать программу используя цикл for, которая вычисляет произведение ряд*");
        Console.WriteLine("*да по формуле, при n = 2                                                 *");

        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int value = 2;
        int startValue = 1;
        int endValue = 5;

        Console.WriteLine($"Переменная X = {value}");
        Console.WriteLine($"Старт шага = {startValue}");
        Console.WriteLine($"Конец шага X = {endValue}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();

        var result = ds.GetMultiplySeries(value, startValue, endValue);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}