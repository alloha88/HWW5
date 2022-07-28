// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Здраствуйте , эта программа поможет найти точку пересечения двух прямых.");
Console.WriteLine("Для этого нужно решить уровнения: y = k1 * x + b1 и y = k2 * x + b2");
Console.WriteLine("Введите число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = (b2 - b1)/(k1 - k2);
double y = (k2*b1-k1*b2)/(k2-k1);
Console.WriteLine("Точка пересечения двух прямых = " + x + "," + y);
