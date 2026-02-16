using MyLibrary;
using System;

class Program
{
    static void Main()
    {
        var math = new BasicMath();
        Console.WriteLine("Сложение 10 + 5 = " + math.Add(10, 5));
        Console.WriteLine("Умножение 4 * 3 = " + math.Multiply(4, 3));

        try
        {
            Console.WriteLine("Деление 20 / 4 = " + math.Divide(20, 4));
         
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }

        Console.Write("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}

