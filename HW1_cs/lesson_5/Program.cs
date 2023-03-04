using System.Security.Cryptography;

namespace lesson_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int abciss_X = Convert.ToInt16(Console.ReadLine());
            int ordinate_Y = Convert.ToInt16(Console.ReadLine());
            if (ordinate_Y >= 0 && Math.Sqrt(abciss_X * abciss_X + ordinate_Y + ordinate_Y) <= 1 && ordinate_Y > Math.Abs(abciss_X))
            {
                Console.WriteLine(abciss_X + ordinate_Y);
            }
            else
            {
                Console.WriteLine(abciss_X - ordinate_Y);
            }
        }
    }
}