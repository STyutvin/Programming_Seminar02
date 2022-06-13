internal class Program
{
    private static void Main(string[] args)
    {
        //Задача 1. Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным.
        Console.Write("Введите длину стороны AB: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите длину стороны BC: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите длину стороны AC: ");
        int c = Convert.ToInt32(Console.ReadLine());
        if (a == b || a == c || b == c)
        {
            Console.WriteLine("Треугольник ABC является равнобедренным");
        }
        else
        {
            Console.WriteLine("Треугольник ABC не является равнобедренным");
        }
    }
}