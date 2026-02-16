using System;

class Program
{
    static char[] b = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static char p = 'X';

    static void Draw()
    {
        Console.Clear();
        Console.WriteLine(b[0] + " | " + b[1] + " | " + b[2]);
        Console.WriteLine("--+---+--");
        Console.WriteLine(b[3] + " | " + b[4] + " | " + b[5]);
        Console.WriteLine("--+---+--");
        Console.WriteLine(b[6] + " | " + b[7] + " | " + b[8]);
    }

    static bool Win()
    {
        if (b[0] == b[1] && b[1] == b[2]) return true;
        if (b[3] == b[4] && b[4] == b[5]) return true;
        if (b[6] == b[7] && b[7] == b[8]) return true;

        if (b[0] == b[3] && b[3] == b[6]) return true;
        if (b[1] == b[4] && b[4] == b[7]) return true;
        if (b[2] == b[5] && b[5] == b[8]) return true;

        if (b[0] == b[4] && b[4] == b[8]) return true;
        if (b[2] == b[4] && b[4] == b[6]) return true;

        return false;
    }

    static bool DrawGame()
    {
        for (int i = 0; i < 9; i++)
        {
            if (b[i] != 'X' && b[i] != 'O')
                return false;
        }
        return true;
    }

    static void Main()
    {
        while (true)
        {
            Draw();
            Console.Write("Ход игрока " + p + ": ");

            int n;
            if (!int.TryParse(Console.ReadLine(), out n))
                continue;

            if (n < 1 || n > 9)
                continue;

            if (b[n - 1] == 'X' || b[n - 1] == 'O')
                continue;

            b[n - 1] = p;

            if (Win())
            {
                Draw();
                Console.WriteLine("Победил " + p);
                break;
            }

            if (DrawGame())
            {
                Draw();
                Console.WriteLine("Ничья");
                break;
            }

            if (p == 'X') p = 'O';
            else p = 'X';
        }

        Console.ReadKey();
    }
}