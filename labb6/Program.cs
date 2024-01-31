void factorial(double nn, out double x)
{
    x = 1;
    for (int i = 1; i < +nn; i++)
    {
        x = x * i;
    }
}
void stepen(double a, double k, out double x)
{
    x = 1;
    for (int i = 1; i <= k; i++)
    {
        x = x * a;
    }
}
Console.WriteLine("введите x,c,k");
double x = double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());
double k = double.Parse(Console.ReadLine());
stepen(c - x, k, out double s1);
stepen(c, k, out double s2);
factorial(c, out double p1);
factorial(k, out double p2);
double f = s1 / (s2 * (p1 - p2));
Console.WriteLine($"f = {f}");