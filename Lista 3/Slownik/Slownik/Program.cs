using System;


namespace Slownik
{
    class Program
    {
        static void Main(string[] args)
        {
            Słownik<int, string> dict = new Słownik<int, string>();
            Console.WriteLine("pumpumpum");
            dict.Dodaj(23, "nowy Patyczek1");
            
            dict.Wydrukuj();
            Console.WriteLine("pumpumpum");
            dict.Dodaj(23, "nowy Patyczek2");
            dict.Wydrukuj();
            Console.WriteLine("pumpumpum");
            dict.Dodaj(25, "nowy Patyczek3");
            dict.Wydrukuj();
            Console.WriteLine("pumpumpum");
            dict.Usun(25);
            dict.Wydrukuj();
            Console.WriteLine("pumpumpum");
        }
    }
}
