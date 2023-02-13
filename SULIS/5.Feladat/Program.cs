using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Add meg a víz hőmérsékletét: ");
            a = int.Parse(Console.ReadLine());
            if (a <= 0)
                Console.WriteLine("A víz Szilárd halmazállapotú");
            if (a > 0 && a < 100)
                Console.WriteLine("A víz Folyékpny halmazállapotú");
            if (a <= 100)
                Console.WriteLine("A víz Gőz halmazállapotú");
            Console.ReadKey();
        }
    }
}

