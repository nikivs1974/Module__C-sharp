int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

// int[] array = GetArray(5, 1, 10);
int[] array = { 1, 2, 3 };
Console.WriteLine($"{String.Join(", ", array)}");

int[] ReverseArray(int[] array)
{
    int count = array.Length - 1;
    int[] tempArr = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        tempArr[i] = array[count];
        count --;
    Console.WriteLine(count);
    }
    return tempArr;
}
int[] revArray = ReverseArray(array);
Console.WriteLine($"[{String.Join(", ", revArray)}]");