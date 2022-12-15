// Задача №5: Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

// 4 -> -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 -> -2, -1, 0, 1, 2

internal class Program
{
    private static void Main(string[] args)
    {
        int number = EnterNumber("Введите число не равное 0");
        int increment;
        if (number > 0)
        {
            increment = 1;
        }
        else
        {
            increment = -1;
        }
        System.Console.Write($"{number} -> ");
        for (int i = number * -1; i != number + increment; i += increment)
        {
            if (i != number)
            {
                System.Console.Write($"{i}, ");
            }
            else
            {
                System.Console.Write(i);
            }
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