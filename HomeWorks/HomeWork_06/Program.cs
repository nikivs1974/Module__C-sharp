// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Write("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine()!);
int GetNum(int M)
{
    int[] array = new int[M];
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write($"Введите {i+1} число: "); 
       array[i] = Convert.ToInt32(Console.ReadLine()!);
       if(array[i] > 0)
       {
        result++;
       }
    }
    Console.WriteLine($"[{String.Join(",\t", array)}]");
    return result;
}
int num = GetNum(M);
Console.WriteLine($"Количество чисел больше 0 = {num}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// y = k1 * x + b1, y = k2 * x + b2
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine()!);

string GetPoint(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = k1 * x + b1;
    return $"({x}; {y})"; 
}

Console.WriteLine(GetPoint(b1, k1, b2, k2));




