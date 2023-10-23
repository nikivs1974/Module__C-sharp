﻿﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string GetNum(int N)
{
    if (N == 1) return $"{N}";
    return $"{N}, {GetNum(N-1)}";
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()!);
Console.Write($"Натуральные числа в промежутке от {num} до 1: ");
Console.WriteLine(GetNum(num));
Console.WriteLine();

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSum(int M, int N)
{
    if(M == N) return M;
    else if(M > N) return 0;
    return M + GetSum(M + 1, N);
}

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} равна: {GetSum(M, N)}");
Console.WriteLine();

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Accerman(int m, int n)
{
    if (m < 0 || n < 0) return 0;
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Accerman(m - 1, 1);
    return Accerman(m - 1, Accerman(m, n - 1));
}

Console.Write("Введите положительное число m: ");
int m = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите положительное число n: ");
int n = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine($"A({m}, {n}) = {Accerman(m, n)}");