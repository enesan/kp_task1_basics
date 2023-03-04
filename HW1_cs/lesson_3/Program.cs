namespace lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int abciss_X = Convert.ToInt16(Console.ReadLine());
            int ordinate_Y = Convert.ToInt16(Console.ReadLine());
            if (Math.Sqrt(abciss_X * abciss_X + ordinate_Y * ordinate_Y) >= 1 && Math.Sqrt(abciss_X * abciss_X + ordinate_Y * ordinate_Y) <= 2 && ordinate_Y >= 0)
            {
                Console.WriteLine("1");
            }
            else
            { 
                Console.WriteLine("2"); 
            }
        }
    }
}