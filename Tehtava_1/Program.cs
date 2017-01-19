using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            Console.WriteLine("Anna luku: ");
            luku = int.Parse(Console.ReadLine());


            if (luku == 1)
            {
                Console.WriteLine("Annoit luvun Yksi");
            }

            else if (luku == 2)
            {
                Console.WriteLine("Annoit luvun Kaksi");
            }

            else if (luku == 3)
            {
                Console.WriteLine("Annoit luvun Kolme");
            }


            else
            {
                Console.WriteLine("Joku muu luku");
            }

        }
    }
}
