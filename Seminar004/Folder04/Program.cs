// Выводит массив из 8 элементов, заполненный 0 и 1 в случайном порядке

// Мой вариант
// void RandomArr(int[] array) 
// {
//     for(int i = 0; i < 7; i++)
//     {
//         array[i] = new Random().Next(0,2);
//     }
    
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write($"{col[position]} ");
//         position++;
//     }
// }
// int[] arr = new int[8];
// RandomArr(arr);
// PrintArray(arr);

// Вариант с семинара
int[] GetArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(2);
    }
    return array;
}

int[] array = GetArray(8);
Console.WriteLine($"[{String.Join(" ", array)}]");