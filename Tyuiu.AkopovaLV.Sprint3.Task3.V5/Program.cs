using Tyuiu.AkopovaLV.Sprint3.Task3.V5.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        string value = "fifa al fall";
        char replaceable = 'a', replacement = '*';
        Console.Title = "Спринт #3 | Выполнила: Акопова Л. В. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #5                                                              *");
        Console.WriteLine("* Выполнила: Акопова Людмила Владимировна | АСОиУб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл foreach                               *");
        Console.WriteLine("* которая заменяет буквы a на * в строке fifa al fall                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Новая строка: " + ds.ReplaceCharInString(value, replaceable, replacement));
        Console.ReadLine();
    }
}