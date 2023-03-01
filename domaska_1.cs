//#1
//int number = Convert.ToInt32(Console.ReadLine());
//if (number >= 10)
//{
//    if (number <= 99)
//    {
//        if (number % 2 == 0)
//        {
//            Console.WriteLine("True");
//        }
//        else if (number % 2 == 1)
//        {
//            Console.WriteLine("False");
//        }
//    }
//    else if (number > 99)
//    {
//        Console.WriteLine("False");
//    }
//}
//else if (number < 10)
//{
//    Console.WriteLine("False");
//}


//#2
//int number = Convert.ToInt32(Console.ReadLine());
//if (number > 999)
//{
//    if (number % 10 == number / 1000)
//    {
//        if (number % 100 / 10 == number % 1000 / 100)
//        {
//            Console.WriteLine("True");
//        }
//        else if (number % 100 / 10 == number % 1000 / 100)
//        {
//            Console.WriteLine("False");
//        }
//    }
//    else if (number % 10 != number / 1000)
//    {
//        Console.WriteLine("False");
//    }
//}
//else if (number < 1000)
//{
//    Console.WriteLine("False");
//}


//#3
//double x = Convert.ToDouble(Console.ReadLine());
//double y = Convert.ToDouble(Console.ReadLine());
//int square_root = 2;
//if (y > 0)
//{
//    if ((Math.Pow(x, square_root) + Math.Pow(y, square_root)) <= 4)
//    {
//        if ((Math.Pow(x, square_root) + Math.Pow(y, square_root)) >= 1)
//        {
//            Console.WriteLine("1");
//        }
//        else
//        {
//            Console.WriteLine("0");
//        }
//    }
//    else
//    {
//        Console.WriteLine("0");
//    }
//}
//else
//{
//    Console.WriteLine("0");
//}


//#4
//double x = Convert.ToDouble(Console.ReadLine());
//double y = Convert.ToDouble(Console.ReadLine());
//int square_root = 2;
//if (y > 0)
//{
//    if (x < 0)
//    {
//        if ((Math.Pow(x, square_root) + Math.Pow(y, square_root)) <= 1)
//        {
//            Console.WriteLine("0");
//        }
//        else
//        {
//            Console.WriteLine(y);
//        }
//    }
//    else
//    {
//        if ((Math.Pow(x, square_root) + Math.Pow(y, square_root)) <= 1)
//        {
//            if ((Math.Pow(x, square_root) + Math.Pow(y, square_root)) >= 0.09)
//            {
//                Console.WriteLine("0");
//            }
//            else
//            {
//                Console.WriteLine(y);
//            }
//        }
//        else
//        {
//            Console.WriteLine(y);
//        }
//    }
//}
//else
//{
//    Console.WriteLine(y);
//}


//#5
//double x = Convert.ToDouble(Console.ReadLine());
//double y = Convert.ToDouble(Console.ReadLine());
//int square_root = 2;
//if ((Math.Pow(x, square_root) + Math.Pow(y, square_root)) <= 1)
//{
//    if (y >= x)
//    {
//        if (y >= -x)
//        {
//            Console.WriteLine(x + y);
//        }
//    }
//}
//else
//{
//    Console.WriteLine(x - y);
//}


//#6
//int n = Convert.ToInt32(Console.ReadLine());
//double a = Convert.ToDouble(Console.ReadLine());
//double b = Convert.ToDouble(Console.ReadLine());
//double h = (b - a) / n;
//Console.WriteLine($"H = {h}");
//double w = a;
//for (int i = 0; i < n; i++)
//{
//    w = w + h;
//    Console.WriteLine(w);
//}


//#7
//double a = Convert.ToDouble(Console.ReadLine());
//int n = Convert.ToInt32(Console.ReadLine());
//double s = 1;
//for (int i = 0; i < n; i++)
//{
//    s = s * a;
//}
//Console.WriteLine(s);


//#8
//int x = Convert.ToInt32(Console.ReadLine());
//if ((x < -10) | ((x > -3) & (x < 3)) | (x > 5))
//{
//    Console.WriteLine("yesss");
//}
//else
//{
//    Console.WriteLine("noooo");
//}


//#9
//int x = Convert.ToInt32(Console.ReadLine());
//if (((x >= -10) | (x <= -3)) & (x == 3) | (x == 5))
//{
//    Console.WriteLine("yesss");
//}
//else
//{
//    Console.WriteLine("noooo");
//}


//#10
//double s = 1000;
//Console.WriteLine("Введите действительное число от 0 до 25:");
//double p = Convert.ToDouble(Console.ReadLine());
//if ((p > 25) | (p < 0))
//{
//    Console.WriteLine("Число не соответствует диапозону условия");
//}
//else
//{
//    int k = 0;
//    do
//    {
//        s = s * (1 + p / 100);
//        k = k + 1;
//    }
//    while (s < 1100);
//    Console.WriteLine($"Количество месяцев: {k}, итоговый размер вклада: {s}");
//}
