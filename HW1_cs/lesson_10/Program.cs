namespace lesson_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double interest = Convert.ToDouble(Console.ReadLine());
            double initial_deposit = 1000;
            int month_counter = 0;
            interest = (interest + 100) / 100;
            while (initial_deposit < 1100)
            {
                month_counter++;
                initial_deposit += interest;
            }
            Console.WriteLine(month_counter + " " + initial_deposit);

        }
    }
}