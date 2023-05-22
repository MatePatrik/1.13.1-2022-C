using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzámológépOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szam;
            int szam2;
            char muvelet;
            bool a = true;
            Számológép C1 = new Számológép();
            while (a) 
            {
                try
                {
                    Console.WriteLine("Add meg a számot: ");
                    szam = int.Parse(Console.ReadLine());
                    Console.WriteLine("Add meg a másik számot: ");
                    szam2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Add meg a műveletet: ");
                    muvelet = char.Parse(Console.ReadLine());
                    C1.JEL(muvelet);
                    C1.SZAMOL(szam, szam2);
                }
                catch
                {
                    Console.WriteLine("Hibás bemenet!");
                }
            }
            Console.ReadLine();
        }
    }
}