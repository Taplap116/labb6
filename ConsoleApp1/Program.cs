double f(double nn)
{
    double x = 1;
    for (int i = 1; i <= nn; i++)
        x = x * i;
    return x;
}
double s(double a,double k)
{
    double x = 1;
    for (int i = 1; i <= k; i++)
        x = x * a;
    return x;
}
Console.WriteLine("введите x,c,k");
double x=  double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());
double k = double.Parse(Console.ReadLine());
double y = (s(c - x, k) / (s(c, k) * (f(c) - f(k))));
Console.WriteLine($"y={y}");