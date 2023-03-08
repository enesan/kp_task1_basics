using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string s;
            s = Console.ReadLine();
            double x;
            x = Convert.ToDouble(s);
            string s1;
            s1 = Console.ReadLine();
            double y;
            y = Convert.ToDouble(s1);

            if (y >= 0 && x * x + y * y <= 1)
            {
                if ((x * x + y * y >= 0.09 && x > 0) || (x <= 0))
                {
                    Console.WriteLine(0);
                }
            }
            else { Console.WriteLine(y); }

            Console.ReadLine();
        }
    }
}
