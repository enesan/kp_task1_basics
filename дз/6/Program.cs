using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {



            string s;
            s = Console.ReadLine();
            int n;
            n = Convert.ToInt32(s);
            string s1;
            s1 = Console.ReadLine();
            double a;
            a = Convert.ToDouble(s1);
            string s2;
            s2 = Console.ReadLine();
            double b;
            b = Convert.ToDouble(s2);
            double l;

            double x; x = a;
            l = b - a;
            Console.WriteLine("h = ", l / n);

            for int i = n+1
            {
//??????????????/
                Console.WriteLine(x);
                x += l / b;
            }

            Console.ReadLine();

        }
    }
}
