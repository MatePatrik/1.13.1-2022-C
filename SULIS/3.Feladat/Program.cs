using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            float dc,df;
            string b, c;
            
            Console.WriteLine("Add meg a hőmérsékletet: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("C/F ");
            b = string.Format(Console.ReadLine());
            dc = (float)(a * 1.8 + 32);
            df = (float)((a-32)*0.5556);
            if (b == "C") 
            { 
                Console.WriteLine("Át akarod váltani Fahrenheitbe? i/n: ");
                c = string.Format(Console.ReadLine());
            if (c == "i")
                Console.WriteLine("Ennyi Fahrenheitbe: {0}", dc);
            }
            else if (b == "F")
            { 
                Console.WriteLine("Át akarod váltani Celsiusba? i/n: ");
                c = string.Format(Console.ReadLine());
            if (c == "i")
                Console.WriteLine("Ennyi Celsiusba: {0}", df);
            }
            Console.ReadKey();
        }
    }
}
