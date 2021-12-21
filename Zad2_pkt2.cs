using System;

namespace Zad2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double silnia = 1;
            for (int a = 1; a <= 20; a++)
            {
                silnia *= a;
                Console.WriteLine(silnia);
            }
        }
    }
}
