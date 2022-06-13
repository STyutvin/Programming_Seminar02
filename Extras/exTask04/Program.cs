/*
//Дано натуральное число. Определить его максимальную цифру. Определить его минимальную цифру.
int n = 10, min = 9, max = 0, d;
   Console.Write("Введите натуральное число: ");
   n = Convert.ToInt32(Console.ReadLine());
   while (n > 0)
   {
      d = n % 10;
      if (d < min)
         min = d;
      if (d > max)
         max = d;
      n = n/10;
   }
   Console.WriteLine($"Минимальная цифра - {min}, максимальная цифра - {max}");
   Console.ReadKey();
*/   