using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите сумму вклада: ");
        decimal money = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Введите количество месяцев: ");
        int months = Convert.ToInt32(Console.ReadLine());

        int i = 0;
        while (i < months)
        {
            money = money + money * 0.07m;
            i++;
        }

        Console.WriteLine("Конечная сумма: " + money);
    }
}