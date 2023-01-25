using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napišite program koji će za definirani niz tipa double pronaći član koji najmanje odstupa od 
            //prosječne vrijednosti niza.Program mora raditi ispravno za proizvoljni broj članova niza.

            double[] niz = { 15.2, 31.7, 5.2, 19.4, 1.2, 25.5};
            double prosjek=0, najmanji=niz[0], broj=0;

            for(int i = 0; i < niz.Length; i++)
            {
                prosjek += niz[i];
            }

            prosjek /= niz.Length;

            for(int i = 0; i < niz.Length; i++)
            {
                broj = niz[i];
                if (broj < prosjek && najmanji < prosjek)
                {
                    if(prosjek - broj < prosjek - najmanji)
                    {
                        najmanji = broj;
                    }
                }
                else if(broj < prosjek && najmanji > prosjek)
                {
                    if (prosjek - broj < najmanji - prosjek)
                    {
                        najmanji = broj;
                    }
                }
                else if(broj > prosjek && najmanji < prosjek)
                {
                    if (broj - prosjek < prosjek - najmanji)
                    {
                        najmanji = broj;
                    }
                }
                else
                {
                    if(broj - prosjek < najmanji - prosjek)
                    {
                        najmanji = broj;
                    }
                }
            }

            Console.WriteLine("Najbliži broj prosjeku je " + najmanji + ", prosjek je " + prosjek);

            Console.ReadKey();
        }
    }
}
