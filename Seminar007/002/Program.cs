// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
int m = 3;
int n = 4;
void GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}
GetMatrix(m, n);
Console.WriteLine();

void GetMatrix2(int m, int n)
{
    int[,] matrix = new int[m, n];
    // int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = matrix.GetLength(1) * i + j;
            // matrix[i, j] = count;
            // count++;
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

GetMatrix2(m, n);