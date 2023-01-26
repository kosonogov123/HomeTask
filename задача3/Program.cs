Console.Clear();
Console.WriteLine("Напишите номер дня недели, программа выдаст его название");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 1)
Console.WriteLine("понедельник");
if (n == 2)
Console.WriteLine("вторник");
if (n == 3)
Console.WriteLine("среда");
if (n == 4)
Console.WriteLine("четверг");
if (n == 5)
Console.WriteLine("пятница");
if (n == 6)
Console.WriteLine("суббота");
if (n == 7)
Console.WriteLine("воскресенье");
else if (n > 7)
Console.WriteLine("Вы ввели слишком большое число, попробуйте от 1 до 7");
