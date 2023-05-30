using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kp_task1_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("#1: \t");
            int A = Convert.ToInt32(Console.ReadLine());
            if (A % 100 == A &&  A % 2 == 0) {Console.WriteLine("true");}    
            else { Console.WriteLine("false");}           


            Console.Write("#2: \t");
            int A2 = Convert.ToInt32(Console.ReadLine());
            if (A2%10*10 + A2%100/10 == A2/100) {Console.WriteLine("true"); }
            else {Console.WriteLine("false"); }           


            Console.Write("#3: \t");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if (y > 0 && y * y + x * x > 1 && y * y + x * x < 4) { Console.WriteLine(1); }
            else { Console.WriteLine(0); }


            Console.Write("#4: \t");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            if (y1 > 0 && y1 * y1 + x1 * x1 > 1)
            {
                if (x1 < 0.3 && x1 > 0 && y1 > 0 && y1 * y1 + x1 * x1 < 0.3*0.3) { Console.WriteLine(y1); }
                else { Console.WriteLine(0); }
            }
            else { Console.WriteLine(y1); }



            Console.Write("#5: \t");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            if (y2 > -x2 && y2 > x2 && y2 * y2 + x2 * x2 < 1) { Console.WriteLine(x2 + y2); }
            else { Console.WriteLine(x2 - y2); }


            Console.Write("#6: \t");
            double N = Convert.ToDouble(Console.ReadLine());
            double A1 = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double H = (B - A1) / N;
            Console.WriteLine(H);
            while (A1 <= B)
            {
                Console.WriteLine(A);
                A1 = A1 + H;
            }


            Console.Write("#7: \t");
            int A3 = Convert.ToInt32(Console.ReadLine());
            int N2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Pow(A3,N2));


            Console.Write("#8: \t");
            double P = Convert.ToInt32(Console.ReadLine());
            double S = 1000, K = 0;
            while (S <= 1100)
            {
                S = S + (S / 100 * P);
                K++;
            }
            Console.WriteLine(K);
            Console.WriteLine(S);

        }
    }
}
