internal class Program
{
    private static void Main(string[] args)
    {
        //Задача 4. Дано натуральное число, в котором все цифры различны. Определить, какая цифра расположена в нем левее: максимальная или минимальная.
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        string str = Convert.ToString(number);
        int arrLen = str.Length;
        int[] array = new int[arrLen];
        for (int i = arrLen - 1; i >= 0; i--)
        {
            array[i] = number % 10;
            number /= 10;
        }
        int max = array[0];
        int min = array[0];
        int maxIndex = 0;
        int minIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                minIndex = i;
            }
        }
        if (maxIndex > minIndex)
        {
            Console.WriteLine($"Во введенном числе {str} максимальная цифра {max} находится правее минимальной цифры {min}");
        }
        else
        {
            Console.WriteLine($"Во введенном числе {str} максимальная цифра {max} находится левее минимальной цифры {min}");
        }
    }
}