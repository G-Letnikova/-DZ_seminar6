// Задача 43 ___ найти точку пересечения двух прямых, заданных уравнением  y=k1*x+b1, y=k2*x+b2
//               знаения b1,k1,b2,k2 вводятся пользователем__________

Console.Clear();
Console.Write("Введите через пробел значения b1 и k1: ");
double[] b1k1 = Console.ReadLine().Split(" ").Select(x => double.Parse(x)).ToArray();
Console.Write("Введите через пробел значения b2 и k2: ");
double[] b2k2 = Console.ReadLine().Split(" ").Select(x => double.Parse(x)).ToArray();
double x = (b2k2[0] - b1k1[0]) / (b1k1[1] - b2k2[1]);
double y = b1k1[1] * x + b1k1[0];

Console.WriteLine($"Точка пересечения прямых: {y}; {y}");
