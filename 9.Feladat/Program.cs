using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("Add meg a CO mennyiségét");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a O mennyiségét");
            b = float.Parse(Console.ReadLine());
            c = (a / b);
            if (0.8 > c)
                Console.WriteLine("Zsirokból nyeri")
            else if (0.8 < c)
                Console.WriteLine("szénhidrátokból nyeri")
            else
                Console.WriteLine("tökéletes")
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
