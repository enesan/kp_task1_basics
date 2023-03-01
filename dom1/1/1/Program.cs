//1
//Random rnd = new Random();
//int a = rnd.Next(0, 200);
//Console.WriteLine(a);
//int s = a;
//if ((a%2==0) & (a%100==s)) {
//    Console.WriteLine("Данное число является четным двузначным");
//}
//else
//{
//    Console.WriteLine("Данное число не является четным двузначным");
//}


//2
//Random rnd = new Random();
//int a = rnd.Next(1000, 9999);
//Console.WriteLine(a);
//if ((a/1000 == a%10) & ((a / 100) % 10 == (a % 100) / 10))
//{
//    Console.WriteLine("Данное число читается одинаково слева направо и справа налево");
//}
//else
//{
//    Console.WriteLine("Данное число не читается одинаково слева направо и справа налево");
//}


//3
//int x = Convert.ToInt32(Console.ReadLine());
//int y = Convert.ToInt32(Console.ReadLine());
//if (y > 0)
//{
//    if (((Math.Pow(x, 2)+Math.Pow(y, 2))<=4) & (Math.Pow(x, 2) + Math.Pow(y, 2)) >= 1)
//    {
//        Console.WriteLine("1");

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


//4
//int x = Convert.ToInt32(Console.ReadLine());
//int y = Convert.ToInt32(Console.ReadLine());
//if (y > 0)
//{
//    if (x < 0)
//    {
//        if ((Math.Pow(x, 2)+Math.Pow(y, 2)) <= 1)
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
//        if (((Math.Pow(x, 2) + Math.Pow(y, 2)) <= 1) &(Math.Pow(x, 2) + Math.Pow(y, 2)) >= 0.09)
//        {
//            Console.WriteLine("0");
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


////5
//int x = Convert.ToInt32(Console.ReadLine());
//int y = Convert.ToInt32(Console.ReadLine());
//if (((Math.Pow(x, 2) + Math.Pow(y, 2)) <= 1) & (y >= x) & (y >= -x))
//{
//    Console.WriteLine(x + y);
//}
//else
//{
//    Console.WriteLine(x - y);
//}


////6
//int n = Convert.ToInt32(Console.ReadLine());
//double a = Convert.ToDouble(Console.ReadLine());
//double b = Convert.ToDouble(Console.ReadLine());
//double h = (b - a) / n;
//Console.WriteLine(h);
//double z = a;
//for (int i = 0; i < n; i++)
//{
//    z = z + h;
//    Console.WriteLine(z);
//}


////7
//double a = Convert.ToDouble(Console.ReadLine());
//int n = Convert.ToInt32(Console.ReadLine());
//double s = 1;
//for (int i = 0;i < n; i++)
//{
//    s = s * a;
//}
//Console.WriteLine(s);


////8
//int x = Convert.ToInt32(Console.ReadLine());
//if ((x < -10) | ((x > -3) & (x < 3)) | (x > 5))
//{
//    Console.WriteLine("yep");
//}
//else
//{
//    Console.WriteLine("noup");
//}

////9
//int x = Convert.ToInt32(Console.ReadLine());
//if (((x >= -10) & (x <= -3)) | (x == 3) | (x == 5))
//{
//    Console.WriteLine("yep");
//}
//else
//{
//    Console.WriteLine("noup");
//}


////10
//double s = 1000;
//double p = Convert.ToDouble(Console.ReadLine());
//int k = 0;
//while (s < 1100)
//{
//    s = s * (1 + p / 100);
//    k++;
//}
//Console.WriteLine(s);
//Console.WriteLine(k);
