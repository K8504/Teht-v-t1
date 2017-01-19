using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna matka kilometreinä: ");
            double matka;
            double kulutus = 7.02/100;
            double hinta = 1.595;

            matka = double.Parse(Console.ReadLine());
            double mkulutus = matka * kulutus;
            double kustannus = mkulutus * hinta;
            Console.WriteLine("Bensaa kuluu: " + mkulutus + " litraa," + " kustannus: " + 
                kustannus + " euroa");

        }
    }
}
