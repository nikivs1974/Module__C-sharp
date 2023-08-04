// int[] arr1 = { 1, 2 };
// int[] arr2 = new int[2];
// int[] arr3 = new int[] { 1, 2 };
// int[] arr2 = new int[2] { 1, 2 };

int[] array = { 1, 2, 3, 4, 5, 4, 7, 8 };
int n = array.Length;
int find = 4;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
int[] arr2 = new int[3]; // Массив заполняется нулями
Console.WriteLine($"{arr2[0]}, {arr2[1]}, {arr2[2]}");

// Заполнение массива случайными числами
void FillArray(int[] collection)
{
    int length = collection.Length;
    index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index ++;
    }
}
// Метод, который будет печатать массив
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

int[] arr = new int[10];
FillArray(arr);
PrintArray(arr);