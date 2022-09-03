// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int SumNumbers(int M, int N)
{
    if (M > N) return 0;
    return (M + SumNumbers(M + 1, N));
}

Console.WriteLine(SumNumbers(4, 8));
Console.WriteLine(SumNumbers(1, 15));