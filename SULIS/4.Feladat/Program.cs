using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("Add meg a magasságodat (méterben) és a testsúlyodat: ");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = (float)(b/Math.Pow(a,2));
            if (c < 20.5)
                Console.WriteLine("Sovány");
            if (c > 20.5 && c < 26.5)
                Console.WriteLine("Normál");
            if (c > 26.6 && c < 31.9)
                Console.WriteLine("Túlsúly");
            Console.ReadKey();
        }
    }
}
