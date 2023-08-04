// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень, в которую нужно возвести число: ");
int b = int.Parse(Console.ReadLine()!);
int GetNum(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    return result;
}
Console.WriteLine($"{a} в степени {b} = {GetNum(a, b)}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int GetSum(int n)
{
    int result = 0;
    int length = n.ToString().Length;
    for (int i = length; i > 0; i--)
    {
        result = result + n % 10;
        n = n / 10;
    }
    return result;
}
Console.WriteLine($"Сумма цифр числа {n} = {GetSum(n)}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (можно указать любой промежуток)
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GetArray(int length)
{
    int[] arr = new int[length];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(10, 30);
    }
    return arr;
}
int[] array = GetArray(8);
Console.WriteLine($"Массив из 8 элементов, заполненный случайными числами: [{String.Join(", ", array)}]");