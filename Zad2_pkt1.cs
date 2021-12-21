using System;

namespace Zad2_3

{
    class Program
    {
        static void Main(string[] args)
        {
            double silnia = 1;
            for (int a = 1; a <= 9; a++)
            {
                silnia *= a;
                Console.WriteLine(silnia);
            }
        }
    }
}
