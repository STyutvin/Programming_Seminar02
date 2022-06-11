internal class Program
{
    private static void Main(string[] args)
    {
        //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        Console.Write("Введи число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        string numText = Convert.ToString(num);
        if (numText.Length > 2)
        {
            Console.WriteLine("третья цифра -> " + numText[2]);
        }
        else
        {
            Console.WriteLine("-> третьей цифры нет");
        }
    }
}