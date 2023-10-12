// выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


Console.WriteLine("Enter fibonachi number: ");
int N = Convert.ToInt32(Console.ReadLine()!);

void Fib(int n)
{
    int[] result = new int[n];
    result[1] = 1;
    for (int i = 2; i < n; i++)
        {
            result[i] = result[i-2] + result[i-1];
        }
    Console.WriteLine(String.Join(" ", result));
}
Fib(N);

