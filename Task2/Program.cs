// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

internal class Program
{
    private static void Main(string[] args)
    {
        int number1 = EnterNumber("Введите первое число");
        int number2 = EnterNumber("Введите второе число");

        if (number1 > number2)
        {
            System.Console.WriteLine($"Первое число {number1} больше чем второе число {number2}");
        }
        else if (number2 > number1)
        {
            System.Console.WriteLine($"Второе число {number2} больше чем первое число {number1}");
        }
        else
        {
            System.Console.WriteLine($"Числа {number1} и {number2} равны");
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