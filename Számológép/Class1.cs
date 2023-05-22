using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzámológépOOP
{
    internal class Számológép
    {
        public char muvelet;
        public Számológép() { }
        public void JEL(char muvelet)
        {
            this.muvelet = muvelet;
        }
        public void SZAMOL(float szam, float szam2)
        {
            if (this.muvelet == '+')
            {
                szam += szam2;
                Console.WriteLine(szam);
            }
            else if (this.muvelet == '-')
            {
                szam -= szam2;
                Console.WriteLine(szam);
            }
            else if (this.muvelet == '*')
            {
                szam *= szam2;
                Console.WriteLine(szam);
            }
            else if (this.muvelet == '/')
            {
                szam /= szam2;
                Console.WriteLine(szam);
            }
            else
            {
                Console.WriteLine("Hibás bemenet!");
            }
        }
    }
}