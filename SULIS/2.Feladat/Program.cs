using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Adj meg egy számot: ");
            a = int.Parse(Console.ReadLine());
            if (a % 3 == 0)
                Console.WriteLine("3-el osztható");
            if (a % 4 == 0)
                Console.WriteLine("4-el osztható");
            if (a % 9 == 0)
                Console.WriteLine("9-el osztható");
            Console.ReadKey();
        }
    }
}
