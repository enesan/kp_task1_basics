using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            s = Console.ReadLine();
            int a;
            a = Convert.ToInt32(s);

            if ( ((a / 1000) == (a % 10)) && (a / 10 % 10)==(a / 100 % 10))
            {
                Console.WriteLine("true");

            }
            else { Console.WriteLine("false"); }

            Console.ReadLine();


        }
    }
}
