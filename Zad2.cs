using System;

namespace Zad2

{
    class Program
    {
        static void Main(string[] args)

        {
            int silnia = 1;
            for (int a = 1; a <= 9; a++)
            {
                silnia *= a;
                Console.WriteLine(silnia);
            }
        }
    }
}
