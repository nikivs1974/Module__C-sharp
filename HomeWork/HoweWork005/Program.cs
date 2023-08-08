// Метод заполнения массива случайными числами
int[] GetArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int GetEven(int[] collection)
{
    int result = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] % 2 == 0)
        {
            result++;
        }
    }

    return result;
}

int[] array = GetArray(4, 1, 999); ;
Console.WriteLine($"Массив: [{String.Join(", ", array)}]");
Console.WriteLine($"Количество четных чисел в массиве = {GetEven(array)}\n");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int GetSum(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            result += array[i];
        }
    }

    return result;
}

int[] arr = GetArray(4, 1, 99);
Console.WriteLine($"Массив: [{String.Join(", ", arr)}]");
Console.WriteLine($"Сумма элементов, стоящих на нечётных индексах = {GetSum(arr)}\n");

// Задача 38: Задайте массив целых чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3, 4, 1, 77, 65] => 77 - 1 = 76

int GetDiff(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] <= min)
        {
            min = array[i];
        }
    }

    return max - min;
}

int[] col = GetArray(4, 1, 99);
Console.WriteLine($"Массив: [{String.Join(", ", col)}]");
Console.WriteLine($"Разницу между макс и мин элементами массива = {GetDiff(col)}\n");