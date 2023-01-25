using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fibonaccijev niz definiran je na sljedeći način: 
            //• prvi član niza je 0
            //• drugi član niza je 1
            //• svaki sljedeći član niza jednak je zbroju prethodna dva člana
            //Napišite program koji će zatražiti od korisnika da unese broj n, te će izračunati n-ti član
            //Fibonaccijevog niza.

            int n, stari = 0, novi = 1, korak=0;

            Console.WriteLine("Unesite n-ti član Fibonaccijevog niza: ");
            n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                korak = novi;
                novi = stari + novi;
                stari = korak;
            }
            //0+1 = 1, 1+1 = 2, 1+2 = 3, 2+3 = 5,
            Console.WriteLine(novi);

            Console.ReadKey();
        }
    }
}
