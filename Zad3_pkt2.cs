using System;

namespace Kalkulator3
{
    class Program
    {
        static void Main(string[] args)

        {
            
            Console.WriteLine("Wpisz pierwszą liczbę");
            var liczba1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Jaką operacje chcesz wykonać?(+,-,*,/)");
            var operacja = Console.ReadLine();
            Console.WriteLine("Wpisz drugą liczbę");
            var liczba2 = int.Parse(Console.ReadLine());
            var wynik = 0;
            switch (operacja)
            {
                case "+":
                    wynik = liczba1 + liczba2;
                    break;
                case "-":
                    wynik = liczba1 - liczba2;
                    break;
               
                default:
                    throw new Exception("Wybrałeś złą operację!");
            }



            Console.WriteLine("Twój wynik to:");
            Console.WriteLine(wynik);


        }
    }
}
