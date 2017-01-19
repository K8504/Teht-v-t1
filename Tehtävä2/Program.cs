using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä2
{
    class Program
    {
        static void Main(string[] args)
        {
            int pisteet;

            Console.WriteLine("Anna pistemaarasi ja paina Enter ");
            pisteet = int.Parse(Console.ReadLine());

            if (pisteet <= 1) Console.WriteLine("Koulunumero on 0");

            else if (pisteet == 2 || pisteet == 3) Console.WriteLine("Koulunumero on 1");

            else if (pisteet == 4 || pisteet == 5) Console.WriteLine("Koulunumero on 2");

            else if (pisteet == 6 || pisteet == 7) Console.WriteLine("Koulunumero on 3");

            else if (pisteet == 8 || pisteet == 9) Console.WriteLine("Koulunumero on 4");

            else if (pisteet == 10 || pisteet == 11 || pisteet == 12) Console.WriteLine("Koulunumero on 5");
        }
    }
}
