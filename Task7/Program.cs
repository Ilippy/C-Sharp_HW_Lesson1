﻿internal class Program
{
    private static void Main(string[] args)
    {
        int number = EnterNumber("Введите целое трехзначное число");
        int lastDigitOfNumber = number % 10;

        System.Console.WriteLine($"{number} -> {lastDigitOfNumber}");
        
    }


    static int EnterNumber(string str)
    {
        System.Console.WriteLine(str);
        string stringNumber = Console.ReadLine().Trim();
        int number;
        while (!int.TryParse(stringNumber, out number) || number < 100 || number > 999)
        {
            Console.WriteLine("Ошибка! Введите одно трехзначное целое число");
            stringNumber = Console.ReadLine().Trim();
        }
        return number;
    }
}