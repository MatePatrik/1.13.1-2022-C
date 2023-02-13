using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Hány tonna búzát vetettél el? ");
            int[] rekt = {5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            Random random = new Random();
            int b = random.Next(5, rekt.Length);
            a = int.Parse(Console.ReadLine());
            int c = (a * b);
            Console.WriteLine(c);
            if (c >= 5 && c <= 8)
            {
                Console.WriteLine("Átlag alatti");
            }
            else if (c >= 9 && c <= 12)
            {
                Console.WriteLine("Átlagos");
            }
            else if (c >= 13 && c <= 15)
            {
                Console.WriteLine("Átlag feletti");
            }
            else
            {
                Console.WriteLine("Túl sok");
            }
            Console.ReadKey();
        }
    }
}
