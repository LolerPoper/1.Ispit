using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napišite program koji će zatražiti od korisnika da unese dva stringa, te će ih ispisati po abecedi u uzlaznom redoslijedu.

            string s1, s2;
            Console.WriteLine("Unesite string: ");
            s1 = Console.ReadLine();
            Console.WriteLine("Unesite drugi string: ");
            s2 = Console.ReadLine();
            int x;

            if(s1.Length > s2.Length)
            {
                x = s2.Length;
            }
            else
            {
                x = s1.Length;
            }

            for(int i = 0; i < x; i++)
            {
                if(s1[i] < s2[i])
                {
                    Console.WriteLine(s1 + " " + s2);
                    break;
                }
                else
                {
                    Console.WriteLine(s2 + " " + s1);
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
