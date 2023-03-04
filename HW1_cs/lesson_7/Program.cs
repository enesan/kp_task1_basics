namespace lesson_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number_A = Convert.ToDouble(Console.ReadLine());
            int number_N = Convert.ToInt16(Console.ReadLine());
            double result = 1;
            for(int i = 0; i < number_N; i++) 
            {
                result *= number_A;
            }
            Console.WriteLine(result);
        }
    }
}