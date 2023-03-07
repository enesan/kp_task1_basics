int i;
int c=0;
i = Convert.ToInt32(Console.ReadLine());
Console.Write("Otvet na 1 zadanie: \t");
if (i % 2 == 0)
    {
    Console.WriteLine("4etnoe");
    }
else
{
    Console.WriteLine("ne4et");
}
i = Convert.ToInt32(Console.ReadLine());
Console.Write("Otvet na 2 zadanie: \t");
if ((i%10==i/1000) & (((i%100)/10)==(i/100)%10))
        {
    Console.WriteLine("+");
}
else
{
    Console.WriteLine("-");

}
double x, y;
x = Convert.ToDouble(Console.ReadLine());
y = Convert.ToDouble(Console.ReadLine());
Console.Write("Otvet na 3 zadanie: \t");
if (Math.Sqrt(x) + Math.Sqrt(y) <= 4)
        {
    if (Math.Sqrt(x) + Math.Sqrt(y) >= 1)
    {
        Console.WriteLine(1);
    }
    else
    {
        Console.WriteLine(0);
    }
}
else
{ Console.WriteLine(0); }
x = Convert.ToInt32(Console.ReadLine());
y = Convert.ToInt32(Console.ReadLine());
Console.Write("Otvet na 4 zadanie: \t");
if ((Math.Sqrt(x) + Math.Sqrt(y) <=1) & ((x > 0.3) & (y > 0.3)))
{
    Console.WriteLine(0);
}    
else
{ Console.WriteLine(y); }
x = Convert.ToInt32(Console.ReadLine());
y = Convert.ToInt32(Console.ReadLine());
Console.Write("Otvet na 5 zadanie: \t");
if ((y > Math.Abs(x)) & (y>=0) & (y<=1))
{
    Console.WriteLine(x + y);
}
else
{
    Console.WriteLine(x - y);
}
int N, A, B,otr, H;

Console.Write("Otvet na 6 zadanie: \t");

N = Convert.ToInt32(Console.ReadLine());
A = Convert.ToInt32(Console.ReadLine());
B = Convert.ToInt32(Console.ReadLine());
otr = B - A;
H = otr / N;
c = 1;

while (((H * c) + A )<= otr)
{
    Console.Write((H * c)+A);
    Console.Write("\t");
    c++;
}

A= Convert.ToInt32(Console.ReadLine());
N = Convert.ToInt32(Console.ReadLine());
Console.Write("Otvet na 7 zadanie: \t");
Console.WriteLine(Math.Pow(A, N));

Console.Write("Otvet na 8 zadanie: \t");
x = Convert.ToInt32(Console.ReadLine());
if ((x<=-10) | ((x<=3) & (x>=-3)) | (x>=5))
{
    Console.WriteLine("Попадает");
}
else
{
    Console.WriteLine("Не попадает");
}

Console.Write("Otvet na 9 zadanie: \t");
x = Convert.ToInt32(Console.ReadLine());
if (((x>=-10) & (x<=-3)) | (x==3) | (x==5))
{
    Console.WriteLine("Попадает");
}
else
{
    Console.WriteLine("Не попадает");
}

Console.Write("Otvet na 10 zadanie: \t");

    float b, summ;
    int counter = 0;
    summ = 1000;
    b= (float)Convert.ToDouble(Console.ReadLine());
    b = (b / 100) + 1;
    while (summ < 1100)
    {
        summ = summ * b;
        counter++;
    }

    Console.WriteLine("kol-vo mesyacev= {0}, itogoviy razmer vklada= {1}", counter, summ);
