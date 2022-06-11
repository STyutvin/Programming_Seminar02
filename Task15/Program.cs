internal class Program
{
    private static void Main(string[] args)
    {
        //Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
        string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        Console.WriteLine("Введите число:");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0 && num < 6)
        {
            Console.WriteLine(days[num - 1] + ". Является рабочим днем.");
        }
        else if (num > 5 && num < 8)
        {
            Console.WriteLine(days[num - 1] + ". Является выходным днем.");
        }
        else
        {
            Console.WriteLine("День недели введен неправильно.");
        }
    }
}