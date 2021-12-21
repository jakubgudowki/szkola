using System;

namespace Kalkulator2
{
    class Program
    {
        static void Main(string[] args)

        {
            
            Console.WriteLine("Wpisz pierwszą liczbę");
            var liczba1 = int.Parse(Console.ReadLine());
        
          
            Console.WriteLine("Wpisz drugą liczbę");
            var liczba2 = int.Parse(Console.ReadLine());
            int wynik = liczba1 * liczba2;
           
         
            



            Console.WriteLine("Twój wynik to:");
            Console.WriteLine(wynik);


        }
    }
}
