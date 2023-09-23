// Разворот массива
int[] array = { 1, 2, 3, 4 };
// 1 метод
void ReverseArray1(int[] array){
    for(int i = 0; i < array.Length / 2; i++){
    int key = array[i];
    array[i] = array[array.Length - i - 1];
    array[array.Length - i - 1] = key;
    }
}

// 2 метод
int[] ReverseArray2(int[] array){
    int[] result = new int[array.Length];
    for(int i = 0; i < array.Length; i++){
        result[i] = array[array.Length - i - 1];
    }
    return result;
}

int[] reverseArr2 = ReverseArray2(array);
Console.WriteLine($"[{String.Join(", ", reverseArr2)}]");

ReverseArray1(array);
Console.WriteLine($"[{String.Join(", ", array)}]");
