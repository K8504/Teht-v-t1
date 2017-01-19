using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna sekunnit: ");
            int num;
            num = int.Parse(Console.ReadLine()); // Parse muuntaa merkkijonon esim "37" numeroksi, jotta sitä voidaan vertailla
            int hour = num / 3600;
            int min = num / 60 - hour * 60;
            int sec = num % 60;
            
            Console.WriteLine("Antamasi sekunttiaika voidaan ilmaista muodossa: " + hour + "h "
                + min + "min " + sec + "sec");
        }
    }
}