﻿Console.Clear();
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine()), count = 2;
while (count <= n)
{ 
Console.Write($"{count}");
  count = count +2;  
}