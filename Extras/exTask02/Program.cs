internal partial class Program
{
    private static void Main(string[] args)
    {
        //Задача 2. На вход подаются год, номер месяца и день рождения человека, Определить возраст человека на момент 1 июля 2022 года.
        Console.Write("Введите год вашего рождения: ");
        int YearBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите месяц вашего рождения: ");
        int MonthBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите день вашего рождения: ");
        int DayBirth = Convert.ToInt32(Console.ReadLine());
        int age = 2022 - YearBirth;
        if (MonthBirth > 7)
        {
            age = age - 1;
            Console.WriteLine("На 01.07.2022 ваш полный возраст: " + age);
        }
        else
        {
            Console.WriteLine("На 01.07.2022 ваш полный возраст: " + age);
        }
    }
}