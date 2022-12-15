// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

internal class Program
{
    private static void Main(string[] args)
    {
        int number = EnterNumber("Введите число больше 0");
        int i = 2;
        System.Console.Write($"{number} -> ");
        while (i <= number)
        {
            if (i + 2 <= number)
            {
                System.Console.Write($"{i}, ");
            }
            else
            {
                System.Console.Write(i);
            }
            i += 2;
        }

    }


    static int EnterNumber(string str)
    {
        System.Console.WriteLine(str);
        string stringNumber = Console.ReadLine().Trim();
        int number;
        while (!int.TryParse(stringNumber, out number) || number <= 0)
        {
            Console.WriteLine("Ошибка! Введите одно целое положительное число");
            stringNumber = Console.ReadLine().Trim();
        }
        return number;
    }
}