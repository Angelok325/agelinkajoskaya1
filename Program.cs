// See https://aka.ms/new-console-template for more information
Console.WriteLine("Найдите объем цилиндра\n");
Console.Write("Введите радиус:");
double r = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите высоту:");
double h = Convert.ToDouble(Console.ReadLine());
double PI = 3.14;
double d = r * r;
double v = PI * d * h;
Console.WriteLine($"Ваш ответ v = {v}");

