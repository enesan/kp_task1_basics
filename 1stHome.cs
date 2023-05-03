/*
 * Внутри методов написать логику каждого задания.
 * Вместо заглушки в выражении с return, например "return [заглушка]", вернуть результат работы метода
 */
int a = 1; // точка входа, не удалять

public static partial class Program
{
    public static bool Task1(int number)
    {
        if (number % 2 == 0)
            if (number / 100 == 0)
                return true;
            else
                return false;
        else
            return false;
    }
    
    public static bool Task2(int number)
    {
        string rev_number_str = "";
        string number_str = Convert.ToString(number);
        for (int i = number_str.Length - 1; i >= 0; i--)
            rev_number_str = rev_number_str + number_str[i];
        if (number_str == rev_number_str)
            return true;
        else
            return false;
    }

    public static int Task3(int x, int y)
    {
        if ((x * x + y * y <= 4) & (x * x + y * y >= 1))
            return 1;
        else
            return 0;
    }

    public static int Task4(int x, int y)
    {
        if ((y >= 0) & (x * x + y * y <= 1))
            if ((x >= 0) & (y >= 0) & (x * x + y * y >= 0.3 * 0.3))
                return 0;
            else
                return y;
        else
            return y;
    }

    public static int Task5(int x, int y)
    {
        if ((y >= 0) & (x * x + y * y <= 1) & (y >= x) & (y >= -x))
            return x + y;
        else
            return x - y;
    }

    public static void Task6(int n, int a, int b)
    {
        int c = b - a;
        int h = c / n;
        int k = 1;
        while (a < b)
        {
            Console.WriteLine(a);
            a = a + h * k;
            k++;
        }
        // Task6(10, 3, 17);
    }

    public static long Task7(int a, int n)
    {
        int b = a;
        while (n > 1)
        {
            a = a * b;
            n--;
        }
        return a;
    }

    public static void Task8(int initialDeposit, int percent)
    {
        int k = 0;
        while (initialDeposit <= 1100)
        {
            initialDeposit = initialDeposit + initialDeposit * percent / 100;
            k++;
        }
        Console.WriteLine(k + " " + initialDeposit);
    }
}