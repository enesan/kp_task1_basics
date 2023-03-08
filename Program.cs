using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace кп_дз1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//  #1
            int A = Convert.ToInt32(Console.ReadLine());
            if (A % 100 == A &&  A % 2 == 0) {Console.WriteLine("true");}    
            else { Console.WriteLine("false");}
            Console.ReadLine();*/


            /*//  #2
            int A = Convert.ToInt32(Console.ReadLine());
            if (A%10*10 + A%100/10 == A/100) {Console.WriteLine("true"); }
            else {Console.WriteLine("false"); }
            Console.ReadLine();*/


            /*//  #3
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if (y > 0 && y * y + x * x > 1 && y * y + x * x < 4) { Console.WriteLine(1); }
            else { Console.WriteLine(0); }
            Console.ReadLine();*/


            /*//  #4
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if (y > 0 && y * y + x * x > 1)
            {
                if (x < 0.3 && x > 0 && y > 0 && y * y + x * x < 0.3*0.3) { Console.WriteLine(y); }
                else { Console.WriteLine(0); }
            }
            else { Console.WriteLine(y); }
            Console.ReadLine();*/



            /*//  #5
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if (y > -x && y > x && y * y + x * x < 1) { Console.WriteLine(x + y); }
            else { Console.WriteLine(x - y); }
            Console.ReadLine();*/


            /*//  #6
            double N = Convert.ToDouble(Console.ReadLine());
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double H = (B - A) / N;
            Console.WriteLine(H);
            while (A <= B)
            {
                Console.WriteLine(A);
                A = A + H;
            }
            Console.ReadLine();*/


            /*//    #7
            int A = Convert.ToInt32(Console.ReadLine());
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Pow(A,N));
            Console.ReadLine();*/


            //  #8
            double P = Convert.ToInt32(Console.ReadLine());
            double S = 1000, K = 0;
            while (S <= 1100) 
            {
                S = S + (S / 100 * P);
                K ++;
            }
            Console.WriteLine(K);
            Console.WriteLine(S);
            Console.ReadLine(); 

        }
    }
}
