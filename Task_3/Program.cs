// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

int ComputeAckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return ComputeAckermannFunction(m - 1, 1);
    else
        return ComputeAckermannFunction(m - 1, ComputeAckermannFunction(m, n - 1));
}

Console.WriteLine(ComputeAckermannFunction(2, 3));
Console.WriteLine(ComputeAckermannFunction(1, 1));