// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"Натуральные числа от M = {M}, N = {N} -> ");
for (int i = M; i <= N; i++)
{
    if (i < N)
    {
        Console.Write($" {i}");
    }
    if (i == N)
    {
        Console.Write($" {i}");
    }
}