using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definirajte klasu NebeskoTijelo sa sljedećim varijablama članicama:
            //• varijable tipa double
            //BrzinaOkoOsi
            //BrzinaOkoSunca
            //Definirajte klase Planet i Satelit izvedene iz klase NebeskoTijelo, te im definirajte sljedeće
            //konstruktore:
            //Planet(double, double)
            //Satelit(double, double)
            //koji će dodijeliti vrijednosti proslijeđenih argumenata naslijeđenim varijablama članicama
            //Definirajte dva objekta Zemlja i Mjesec tipova Planet i Satelit.

            Planet Zemlja = new Planet(24, 8760);
            Satelit Mjesec = new Satelit(720, 8760);

        }

        class NebeskoTijelo
        {
            public double BrzinaOkoOsi, BrzinaOkoSunca;
        }

        class Planet : NebeskoTijelo
        {
            public Planet(double x, double y)
            {
                BrzinaOkoOsi = x;
                BrzinaOkoSunca = y;
            }
        }

        class Satelit : NebeskoTijelo
        {
            public Satelit(double x, double y)
            {
                BrzinaOkoOsi = x;
                BrzinaOkoSunca = y;
            }
        }
    }
}
