// принимаем 2 числа и проверяем, является ли первое квадратом второго

Console.Clear();
Console.WriteLine("Напишите два числа, программа проверит, является ли первое квадратом второго.");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе число");
int m = Convert.ToInt32(Console.ReadLine());

if (n == m*m)
Console.WriteLine("является");
else
Console.WriteLine("Не является");