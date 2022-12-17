// Доп.задание ___ Найти площадь треугольника по целочисленным координатам вершин _____

Console.Clear();
Console.Write("Введите через пробел координаты x1 y1 x2 y2 x3 y3: ");
int[] s = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int x1 = s[0], y1 = s[1], x2 = s[2], y2 = s[3], x3 = s[4], y3 = s[5];

double a = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow((y1 - y2), 2));
double b = Math.Sqrt(Math.Pow(x2-x3, 2) + Math.Pow((y2 - y3), 2));
double c = Math.Sqrt(Math.Pow(x1-x3, 2) + Math.Pow((y1 - y3), 2));

double p = (a + b + c) / 2;
double area = Math.Sqrt(p*(p - a) * (p - b) * (p - c));
Console.WriteLine($"Площадь треугольника = {Math.Round(area,2)}");

