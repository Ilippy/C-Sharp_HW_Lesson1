// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

internal class Program
{
    private static void Main(string[] args)
    {
        int number = EnterNumber("Введите число не равное 0");
        int increment = 0;
        if (number > 0)
        {
            increment = 2;
        }
        else
        {
            increment = -2;
        }
        int i = increment;
        System.Console.Write($"{number} -> ");
        while (i != number + increment && i != number + increment/2)
        {

            if (i + increment / 2 == number || i == number)
            {
                System.Console.Write(i);
            }
            else
            {
                System.Console.Write($"{i}, ");
            }
            // System.Console.WriteLine($"i = {i}, increment/2 = {increment/2}, number = {number}");
            // if (i + increment / 2 == number || i == number) break;
            i += increment;
        }

    }


    static int EnterNumber(string str)
    {
        System.Console.WriteLine(str);
        string stringNumber = Console.ReadLine().Trim();
        int number;
        while (!int.TryParse(stringNumber, out number) || number == 0)
        {
            Console.WriteLine("Ошибка! Введите одно целое число не равное 0");
            stringNumber = Console.ReadLine().Trim();
        }
        return number;
    }
}