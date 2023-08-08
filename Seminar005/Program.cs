// Массив из 12-и. Заполнен случайными от -9 до 9

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

// Сумма отрицательных и положительных
int[] array = GetArray(12, -9, 9);
Console.WriteLine($"[{String.Join(", ", array)}]");
int positiveSum = 0;
int negativeSum = 0;
foreach (int el in array)
{
    positiveSum += el > 0 ? el : 0;
    negativeSum += el < 0 ? el : 0;
}
Console.WriteLine($"Сумма положительных чисел = {positiveSum}, сумма отрицательных чисел = {negativeSum}\n");

// Замена положительных на отрицательные и наоборот
for (int i = 0; i < array.Length; i++)
{
    array[i] = -array[i];
}
Console.WriteLine("Замена положительных на отрицательные:");
Console.WriteLine($"[{String.Join(", ", array)}]\n");

// Присутствует ли в массиве число, которое ввёл пользователь
// Мой вариант
int[] arr = GetArray(6, 0, 9);
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

string GetAnswer(int number)
{
    string str = "";
    int count = 0;
    foreach (int el in arr)
    {
        if (el == number)
        {
            count++;
        }
    }
    str = count > 0 ? $"Число {number} есть в массиве [{String.Join(", ", arr)}]"
    : $"Число {number} отсутствует в массиве [{String.Join(", ", arr)}]";
    Console.WriteLine(str);
    return str;
}
GetAnswer(number);


// Вариант с семинара
// НЕ РАБОТАЕТ! 
// ЭТОТ СПОСОБ ПЕРЕПИСЫВАЕТ СТРОКУ

int[] arr1 = GetArray(6, 0, 9);
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
string result = "";

foreach (int el in arr1)
{
    result = el == num ? "Да" : "Нет";
    Console.WriteLine(result);
}
Console.WriteLine($"[{String.Join(", ", arr1)}]");
Console.WriteLine(result);

// Мой вариант
// Задать массив из 123 случайных чисел
// Найдите количество элементов, значения которых в отрезке от 10 до 99
// [5, 18, 123, 6, 2] --> 1

int[] arr2 = GetArray(123, 0, 200);

int GetSum(int[] arr2)
{
    int count = 0;
    foreach (int el in arr2)
    {
        if (el >= 10 && el <= 99)
        {
            count++;
        }

    }
    return count;
}
Console.WriteLine($"\n[{String.Join(", ", arr2)}]");
Console.WriteLine($"Количество элементов, значения которых лежат в отрезке от 10 до 99 = {GetSum(arr2)}");

// Мой вариант
// Найти произведение пар чисел в массиве. (Первый - последний, второй - предпоследний).
// В массиве четное кол элементов
// [6, 7, 3, 6] -> 36 21


int[] col = GetArray(5, 1, 9);
Console.WriteLine($"[{String.Join("/", col)}]");

int[] GetMyltiplay(int[] col)
{
    int size = col.Length / 2;
    int count = col.Length - 1;
    if (col.Length % 2 != 0)
    {
        size++;
    }
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = col[i] * col[count];
        count--;
    }
    if (col.Length % 2 != 0)
    {
        result[size - 1] = col[col.Length / 2];
    }
    return result;
}
int[] resultArr = GetMyltiplay(col);
Console.WriteLine($"[{String.Join("/", resultArr)}]");