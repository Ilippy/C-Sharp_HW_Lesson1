internal class Program
{
    private static void Main(string[] args)
    {
        int number = EnterNumber("Введите число от 1 до 7");
        string dayOfTheWeek ="";
        if(number == 1) dayOfTheWeek = "Понедельник";
        if(number == 2) dayOfTheWeek = "Вторник";
        if(number == 3) dayOfTheWeek = "Среда";
        if(number == 4) dayOfTheWeek = "Четверг";
        if(number == 5) dayOfTheWeek = "Пятница";
        if(number == 6) dayOfTheWeek = "Суббота";
        if(number == 7) dayOfTheWeek = "Воскресение";

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