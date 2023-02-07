using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Ird be a pontszámod: ");
            a = int.Parse(Console.ReadLine());
            if (a >=0 && a < 50)
            {
                Console.WriteLine("A jegyed: 1");
            }
            else if (a >= 50 && a < 65)
            {
                Console.WriteLine("A jegyed: 2");
            }
            else if (a >= 65 && a < 80)
            {
                Console.WriteLine("A jegyed: 3");
            }
            else if (a >= 80 && a < 90)
            {
                Console.WriteLine("A jegyed: 4");
            }
            else if (a >= 90 && a < 100)
            {
                Console.WriteLine("A jegyed: 5");
            }
            else
            {
                Console.WriteLine("Hibás az adat!");
            }
            Console.ReadKey();
        }
    }
}
