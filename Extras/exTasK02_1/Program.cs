//Задача 2. На вход подаются год, номер месяца и день рождения человека, Определить возраст человека на момент 1 июля 2022 года. Считаю, что данное условие слишком простое,
//так как, если задан только первый день месяца, то смысл проверки дней теряется. Лучше рассмотреть более универсальный вариант непосредственно с текущей датой.
Console.Write("Введите текущий год: ");
int CurrentYear = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите текущий месяц: ");
int CurrentMonth = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите текущий день: ");
int CurrentDay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите год вашего рождения: ");
int YearBirth = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите месяц вашего рождения: ");
int MonthBirth = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите день вашего рождения: ");
int DayBirth = Convert.ToInt32(Console.ReadLine());
int age = CurrentYear - YearBirth;
if (MonthBirth > CurrentMonth)
{
age = age - 1;
Console.WriteLine($"На {CurrentDay}.{CurrentMonth}.{CurrentYear} ваш полный возраст: " + age);
}
else if (MonthBirth==CurrentMonth && DayBirth>CurrentDay)
{
age = age - 1;
Console.WriteLine($"На {CurrentDay}.{CurrentMonth}.{CurrentYear} ваш полный возраст: " + age);
}
else
{
Console.WriteLine($"На {CurrentDay}.{CurrentMonth}.{CurrentYear} ваш полный возраст: " + age);
}