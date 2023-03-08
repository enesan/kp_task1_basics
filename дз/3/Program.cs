using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
//            x = float(input())
//y = float(input())
//if (y >= 0) and(y * y + x * x <= 4) and(y * y + x * x >= 1):
//    print(1)
//else:
//    print(0)

            string s;
            s = Console.ReadLine();
            double x;
            x = Convert.ToDouble(s);
            string s1;
            s1 = Console.ReadLine();
            double y;
            y = Convert.ToDouble(s1);

            if (y >= 0 && y*y + x*x <=4 && y*y + x*x >= 1)
            {
                Console.WriteLine(1);
            }
            else { Console.WriteLine(0); }

            Console.ReadLine();


        }
    }
}
