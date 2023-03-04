namespace lesson_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int abciss_X = Convert.ToInt16(Console.ReadLine());
            int ordinate_Y = Convert.ToInt16(Console.ReadLine());
            if (abciss_X <= -10 || (abciss_X >= -3 && abciss_X <= 3) || abciss_X >= 5)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}