using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ika;
            Console.WriteLine("Anna ikasi: ");

            ika = int.Parse(Console.ReadLine());

            if (ika < 18) Console.WriteLine("Alaikäinen");
            if (ika >= 18 && 65 >= ika) Console.WriteLine("Aikuinen");
            if (ika > 65) Console.WriteLine("Seniori");
        }
    }
}