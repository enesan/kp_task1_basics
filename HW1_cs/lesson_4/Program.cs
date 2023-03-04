using System.Runtime.InteropServices;

namespace lesson_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int abciss_X = Convert.ToInt16(Console.ReadLine());
            int ordinate_Y = Convert.ToInt16(Console.ReadLine());
            if(ordinate_Y > 0 && ((abciss_X <= 0 && Math.Sqrt(abciss_X * abciss_X + ordinate_Y + ordinate_Y) <= 1 ) || (abciss_X > 0 && Math.Sqrt(abciss_X * abciss_X + ordinate_Y + ordinate_Y) <= 1 && Math.Sqrt(abciss_X * abciss_X + ordinate_Y + ordinate_Y) >= 0.3)) ) 
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(ordinate_Y);
            }
        }
    }
}