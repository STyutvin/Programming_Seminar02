//Задача 3. Иван в начале года открыл счет в банке, вложив 1000 руб. Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы. Определить размер депозита через n месяцев.
double deposit=1000;
int i=0;
Console.Write("Укажите срок, на который оформлен депозит в месяцах: ");
int months = Convert.ToInt32(Console.ReadLine());
while (i<months)
{
    deposit=(deposit/100)*1.5+deposit;
    i++;
}
Console.WriteLine($"Уважаемы клиент, Ваш остаток на счете по прошествии {months} месяцев(-ца) составит {deposit} рубля(-ей)");

/*Если все-таки для начисления процентов используется неизменяемая сумма 1000 рулей, то решение ниже 
double deposit=1000;
double profit;
Console.Write("Укажите срок, на который оформлен депозит в месяцах: ");
int months = Convert.ToInt32(Console.ReadLine());
double percents=deposit/100*1.5;
profit=percents*months+deposit;
Console.WriteLine($"Уважаемы клиент, Ваш остаток на счете по прошествии {months} месяцев(-ца) составит {profit} рубля(-ей)");
*/