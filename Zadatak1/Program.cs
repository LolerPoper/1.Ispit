using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Napišite program u kojem ćete zatražiti od korisnika da unese niz znakova te će svaki razmak zamijeniti znakom '_'.
            string znakovi;
            Console.WriteLine("Unesite niz znakova: ");
            znakovi = Console.ReadLine();

            Console.WriteLine(znakovi.Replace(" ", "_"));

            Console.ReadKey();
        }
    }
}
