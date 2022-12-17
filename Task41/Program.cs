// Задача 41 ___ вводим числа, выводим сколько положительных__________

Console.Clear();
Console.WriteLine("Введите числа через пробел: ");
int[] s = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int count = 0;
for (int i = 0; i < s.Length; i++)
    if (s[i] > 0)
        count++;
Console.WriteLine($"Чисел больше нуля: {count}");
