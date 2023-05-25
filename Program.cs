using System;

namespace CSLight
{
   internal class Program
   {
      static void Main(string[] args)
      {
         int number;
         System.Console.Write("Введите число: ");
         number = Convert.ToInt32(Console.ReadLine());
         if (number % 2 == 0 && number >= 10 && number < 100)
         {
            Console.WriteLine("Yep");
         }
         else
         {
            Console.WriteLine("No");
         }

         // int userNumber;                                     2 задача
         // System.Console.Write("Введите число: ");
         // userNumber = Convert.ToInt32(Console.ReadLine());
         // if (userNumber > 999 && userNumber < 10000 && (userNumber / 1000 == userNumber % 10) && ((userNumber / 100) % 10 == (userNumber % 100) / 10))
         // {
         //    Console.WriteLine("yes");
         // }
         // else
         // {
         //    Console.WriteLine("no");
         // }

         // int abciss_X = Convert.ToInt16(Console.ReadLine()); -------3 задача
         //    int ordinate_Y = Convert.ToInt16(Console.ReadLine());
         //    if (Math.Sqrt(abciss_X * abciss_X + ordinate_Y * ordinate_Y) >= 1 && Math.Sqrt(abciss_X * abciss_X + ordinate_Y * ordinate_Y) <= 2 && ordinate_Y >= 0)
         //    {
         //        Console.WriteLine("1");
         //    }
         //    else
         //    { 
         //        Console.WriteLine("2"); 
         //    }

         // int abciss_X = Convert.ToInt16(Console.ReadLine()); ------4 задача
         // int ordinate_Y = Convert.ToInt16(Console.ReadLine());
         // if (ordinate_Y > 0 && ((abciss_X <= 0 && Math.Sqrt(abciss_X * abciss_X + ordinate_Y + ordinate_Y) <= 1) || (abciss_X > 0 && Math.Sqrt(abciss_X * abciss_X + ordinate_Y + ordinate_Y) <= 1 && Math.Sqrt(abciss_X * abciss_X + ordinate_Y + ordinate_Y) >= 0.3)))
         // {
         //    Console.WriteLine("0");
         // }
         // else
         // {
         //    Console.WriteLine(ordinate_Y);
         // }

         // int abciss_X = Convert.ToInt16(Console.ReadLine()); ---------5 задача
         // int ordinate_Y = Convert.ToInt16(Console.ReadLine());
         // if (ordinate_Y >= 0 && Math.Sqrt(abciss_X * abciss_X + ordinate_Y + ordinate_Y) <= 1 && ordinate_Y > Math.Abs(abciss_X))
         // {
         //    Console.WriteLine(abciss_X + ordinate_Y);
         // }
         // else
         // {
         //    Console.WriteLine(abciss_X - ordinate_Y);
         // }


         // int number_N = Convert.ToInt16(Console.ReadLine());----------6 задача
         // double number_A = Convert.ToDouble(Console.ReadLine());
         // double number_B = Convert.ToDouble(Console.ReadLine());
         // string the_resulting_string = Convert.ToString((number_B - number_A) / number_N) + " - длина отрезка. ";
         // for (double time_point = number_A; time_point < number_B; time_point += (number_B - number_A) / number_N)
         // {
         //    the_resulting_string += time_point + "; ";
         // }
         // the_resulting_string += number_B + " - набор точек, образующий разбиение отрезка [A, B]";
         // Console.WriteLine(the_resulting_string);

         // double number_A = Convert.ToDouble(Console.ReadLine()); --------7 задача
         // int number_N = Convert.ToInt16(Console.ReadLine());
         // double result = 1;
         // for (int i = 0; i < number_N; i++)
         // {
         //    result *= number_A;
         // }
         // Console.WriteLine(result);

         //  int abciss_X = Convert.ToInt16(Console.ReadLine()); ----------8 задача
         //    int ordinate_Y = Convert.ToInt16(Console.ReadLine());
         //    if (abciss_X <= -10 || (abciss_X >= -3 && abciss_X <= 3) || abciss_X >= 5)
         //    {
         //        Console.WriteLine("true");
         //    }
         //    else
         //    {
         //        Console.WriteLine("false");
         //    }
      }
   }
}


