using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a >= 0 && a <= 10 && b >= 0 && b <= 10)
            {
                Console.WriteLine("Результат: " + (a * b));
                break;
            }
            else
            {
                Console.WriteLine("Числа недопустимы, попробуйте снова.");
            }
        }
    }
}
