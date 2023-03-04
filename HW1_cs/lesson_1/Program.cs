namespace lesson_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt16(Console.ReadLine());
            if (number % 2 == 0 && number / 10 > 0 && number / 10 < 10)
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