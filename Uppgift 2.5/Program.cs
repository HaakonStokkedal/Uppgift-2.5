using System;

namespace Uppgift_2._5
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Skriv in en beräkning med två decimaltal där talen multipliceras med varandra. (ex. 5,2*3,8)");
            string text = Console.ReadLine();
            string Texttal1 = text[..2];
            string Texttal2 = text[4..];
            float tal1 = float.Parse(Texttal1);
            float tal2 = float.Parse(Texttal2);
            float produkt = tal1 * tal2;
            Console.WriteLine(produkt);

            Console.ReadKey();
        }
    }
}