Console.Clear();
Console.WriteLine("Введите первое число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int k = Convert.ToInt32(Console.ReadLine());
int max = n;
if (m >= n)
{ max = m;
if (k >= n)
{max = k;}
if (m>k)
{max=m;}
else 
max = n;
}
    Console.Write("max = ");
Console.Write(max);
