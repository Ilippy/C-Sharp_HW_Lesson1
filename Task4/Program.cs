// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

internal class Program
{
    private static void Main(string[] args)
    {
        int number1 = EnterNumber("Введите первое число");
        int number2 = EnterNumber("Введите второе число");
        int number3 = EnterNumber("Введите третье число");

        int max = number1;

        if(number2 > max) max = number2;
        if(number3 > max) max = number3;

        System.Console.WriteLine($"{number1}, {number2}, {number3} -> {max}");
        
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