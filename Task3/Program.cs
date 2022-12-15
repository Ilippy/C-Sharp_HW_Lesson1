// Задача №3: Напишите программу, которая будет выдавать название дня недели по заданаму номеру.

// 3 -> Среда
// 5 -> Пятница

internal class Program
{
    private static void Main(string[] args)
    {
        int number = EnterNumber("Введите число от 1 до 7");
        string dayOfTheWeek = "";

        switch (number)
        {
            case 1:
                dayOfTheWeek = "Понедельник";
                break;
            case 2:
                dayOfTheWeek = "Вторник";
                break;
            case 3:
                dayOfTheWeek = "Среда";
                break;
            case 4:
                dayOfTheWeek = "Четверг";
                break;
            case 5:
                dayOfTheWeek = "Пятница";
                break;
            case 6:
                dayOfTheWeek = "Суббота";
                break;
            case 7:
                dayOfTheWeek = "Воскресение";
                break;
            default:
                Console.WriteLine($"Error! Wrong number!");
                break;
        }


        System.Console.WriteLine($"{number} -> {dayOfTheWeek}");



    }


    static int EnterNumber(string str)
    {
        System.Console.WriteLine(str);
        string stringNumber = Console.ReadLine().Trim();
        int number;
        while (!int.TryParse(stringNumber, out number) || number <= 0 || number > 7)
        {
            Console.WriteLine("Ошибка! Введите одно целое число от 1 до 7");
            stringNumber = Console.ReadLine().Trim();
        }
        return number;
    }
}