// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
int m = 3;
int n = 4;
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 100);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}



// Рандомные вещественные числа
int x = 3;
int y = 4;
double[,] GetDoubleMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 100) + Math.Round(new Random().NextDouble(), 2);
        }
    }
    return matrix;
}
void PrintDoubleMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // Способ 1:
            // Console.Write(string.Format("{0:0.00}\t", matrix[i,j]));
            // Способ 2:
            Console.Write($"{matrix[i,j]:f2}\t");
        }
        Console.WriteLine();
    }
}

PrintMatrix(GetMatrix(m, n));
Console.WriteLine();
PrintDoubleMatrix(GetDoubleMatrix(x, y));