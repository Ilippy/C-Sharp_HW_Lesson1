// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

internal class Program
{
    private static void Main(string[] args)
    {
        int number = EnterNumber("Введите число");

        if (number % 2 == 0)
        {
            System.Console.WriteLine($"{number} -> да");
        }
        else
        {
            System.Console.WriteLine($"{number} -> нет");
        }

    }


    static int EnterNumber(string str)
    {
        System.Console.WriteLine(str);
        string stringNumber = Console.ReadLine().Trim();
        int number;
        while (!int.TryParse(stringNumber, out number))
        {
            Console.WriteLine("Ошибка! Введите одно целое число");
            stringNumber = Console.ReadLine().Trim();
        }
        return number;
    }
}