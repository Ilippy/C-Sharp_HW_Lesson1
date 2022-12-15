// Задача №1: Запишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.

// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет


internal class Program
{
    private static void Main(string[] args)
    {
        int number1 = EnterNumber("Введите первое число");
        int number2 = EnterNumber("Введите второе число");

        if (Math.Pow(number2, 2) == number1)
        {
            System.Console.WriteLine($"a = {number1}, b = {number2} -> да");
        }
        else
        {
            System.Console.WriteLine($"a = {number1}, b = {number2} -> нет");
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