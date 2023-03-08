using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string s;
            s = Console.ReadLine();
            int a;
            a = Convert.ToInt32(s);

            if (a < 100 && a<9 && a % 2 ==0)
            {
                Console.Write("true");
            }
            else
            {
                Console.Write("false");
            }

            Console.ReadLine();
        }
    }
    }
}
