namespace lesson_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number_N = Convert.ToInt16(Console.ReadLine());
            double number_A = Convert.ToDouble(Console.ReadLine());
            double number_B = Convert.ToDouble(Console.ReadLine());
            string the_resulting_string = Convert.ToString((number_B - number_A) / number_N) + " - длина отрезка. ";
            for (double time_point = number_A; time_point < number_B; time_point += (number_B - number_A) / number_N)
            {
                the_resulting_string += time_point + "; ";
            }
            the_resulting_string += number_B + " - набор точек, образующий разбиение отрезка [A, B]";
            Console.WriteLine(the_resulting_string);
        }
    }
}