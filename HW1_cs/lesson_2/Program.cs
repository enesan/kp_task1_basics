namespace lesson_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            if (number[0] == number[3] && number[1] == number[2])
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