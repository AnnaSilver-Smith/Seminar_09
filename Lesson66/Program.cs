// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

using System.Numerics;

Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (M > N || M < 1)
{
    if (M > N)
    {    
        M = Convert.ToInt32(Console.ReadLine());      
        N = Convert.ToInt32(Console.ReadLine());
    }
    if (M < 1)
    {     
        M = Convert.ToInt32(Console.ReadLine());     
        N = Convert.ToInt32(Console.ReadLine());
    }
}




//Через цикл

for (int i = M; i <= N; i++)
{
    if (i <= N)
    {
        sum += i;
    }
}

Console.WriteLine($"Result 1: Сумма натуральных элементов от {M} до {N} -> {sum}");


//Через рекурсию

SumElement(M, N, sum);
void SumElement(int M, int N, int sum)
{
    if (M == N)
    {
        sum += M;
       
    }
    if (M < N) 
    {
        sum += M;
        SumElement(M + 1, N, sum);
    }
}
Console.WriteLine($"Result 2: Сумма натуральных элементов от {M} до {N} -> {sum}");