// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.Write("Введите натуральное число 1: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите натуральное число 2: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"N={N}, M={M}");
for (int i = N; i <= M; i++)
    if (i < M)
    {
        Console.Write($" {i}");
    }
for (int i = M; i <= N; i++)
    if (i == N)
    {
        Console.Write($" {i}");
    }