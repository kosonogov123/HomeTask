// Программа, которая принимает N и выводит все целые числа от -N до N
Console.Clear();
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
int m = -n;
while (n > m-1)
{ Console.Write($"{m} ");
m = m+1;
}

