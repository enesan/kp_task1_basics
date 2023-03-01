Console.WriteLine("Номер 1");

int a = 46;
if (a > 10 && a < 100)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
if (a % 2 == 0)
{
    Console.WriteLine("ЧЕТ");
}
else
{
    Console.WriteLine("НЕЧЕТ");
}

Console.WriteLine("Номер 2");

int i = 1221;
if ((i / 1000 == i % 10) && ((i / 100) % 10 == (i % 100) / 10))
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}

Console.WriteLine("Номер 3");

double x = -1;
double y = 1.5;
if (x >= -2 && x <= 2 && y >= 1 && y <= 2)
{
    Console.WriteLine("1");
}
else
{
    Console.WriteLine("0");
}

Console.WriteLine("Номер 4");

double x1 = 0.3;
double y1 = 0.5;
if (y1 >= 0 && x1 * x1 + y1 * y1 <= 1)
{
    Console.WriteLine("0");
}
else
{
    Console.WriteLine(y1);
}

Console.WriteLine("Номер 5");

double x2 = 0.1;
double y2 = -0.5;
double z = 0;
if (x2 * x2 + y2 * y2 <= 1 && y2 > x2 && y2 > -x2)
{
    z = x2 + y2;
    Console.WriteLine(z);
}
else
{
    z = x2 - y2;
    Console.WriteLine(z);
}

Console.WriteLine("Номер 6");
int n = Convert.ToInt32(Console.ReadLine());
double a1 = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double h = (b - a1) / n;
Console.WriteLine(h);
double z1 = a1;
for (int j = 0; j < n; j++)
{
    z1 = z1 + h;
    Console.WriteLine(z1);
}

Console.WriteLine("Номер 7");
double a2 = Convert.ToDouble(Console.ReadLine());
int n1 = Convert.ToInt32(Console.ReadLine());
double s = 1;
for (int t = 0; t < n1; t++)
{
    s = s * a2;
}
Console.WriteLine(s);

Console.WriteLine("Номер 8");
int x3 = Convert.ToInt32(Console.ReadLine());
if ((x3 < -10) | ((x3 > -3) & (x3 < 3)) | (x > 5))
{
    Console.WriteLine("yep");
}
else
{
    Console.WriteLine("noup");
}

Console.WriteLine("Номер 9");
int x4 = Convert.ToInt32(Console.ReadLine());
if (((x4 >= -10) & (x4 <= -3)) | (x4 == 3) | (x4 == 5))
{
    Console.WriteLine("yep");
}
else
{
    Console.WriteLine("noup");
}

Console.WriteLine("Номер 10");
double s1 = 1000;
double p = Convert.ToDouble(Console.ReadLine());
int k = 0;
while (s1 < 1100)
{
    s1 = s1 * (1 + p / 100);
    k++;
}
Console.WriteLine(s1);
Console.WriteLine(k);