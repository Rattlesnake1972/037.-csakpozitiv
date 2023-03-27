using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _037.csakpozitiv
{
    class Program
    {
        static void Main(string[] args)
        {
            string strLine;
            int intA;
            do
            {
                Console.Clear();
                Console.Write("Kérek egy pozitív számot, mert negatívakat nem vagyok hajlandó kiírni! ");
                strLine = Console.ReadLine();
                intA = Convert.ToInt32(strLine);
                if (intA <= 0)
                {
                    Console.WriteLine("Pozitív számot írj be!");
                }
            } while (intA > 0);

            Console.ReadLine();

        }
    }
}
