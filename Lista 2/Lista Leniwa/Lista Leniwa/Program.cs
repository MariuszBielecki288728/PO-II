using System;


namespace Lista_Leniwa
{
    

    

    class Program
    {
        static void Main(string[] args)
        {
            ListaLeniwa lista1 = new ListaLeniwa();
            Console.WriteLine(lista1.size());
            Console.WriteLine(lista1.element(1));
            Console.WriteLine(lista1.size());
            Console.WriteLine(lista1.element(2));
            Console.WriteLine(lista1.size());
            Console.WriteLine(lista1.element(3));
            Console.WriteLine(lista1.element(4));
            Console.WriteLine(lista1.element(500000));
            Console.WriteLine(lista1.size());
            Pierwsze lista = new Pierwsze();
            Console.WriteLine(lista.size());
            Console.WriteLine(lista.element(1));
            Console.WriteLine(lista.size());
            Console.WriteLine(lista.element(2));
            Console.WriteLine(lista.size());
            Console.WriteLine(lista.element(3));
            Console.WriteLine(lista.element(4));
            Console.WriteLine(lista.element(500000));




        }

    }
}
