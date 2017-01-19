using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kolme lukua");
            int luku1, luku2, luku3;

            luku1 = int.Parse(Console.ReadLine());
            luku2 = int.Parse(Console.ReadLine());
            luku3 = int.Parse(Console.ReadLine());
            int luku = luku1 + luku2 + luku3;
            int kesk = luku / 3;

            Console.WriteLine("Antamiesi lukujen summa on: " + luku);
            Console.WriteLine("Antamiesi lukujen keskiarvo on: " + kesk);
        }
    }
}
