// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// Делим десятичное число на 2 и записываем остаток от деления. 
// Результат деления вновь делим на 2 и опять записываем остаток. 
// Повторяем операцию до тех пор пока результат деления не будет равен нулю.

// 45       100 + 1    101
// 22 1
// 11 0
// 5  1
// 2  1
// 0  1

// Нестандартный метод

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()!);
int count = 0;
double newN = 0;
while (n >= 1)
{
    newN = n % 2 * Math.Pow(10, count) + newN;
    n = n / 2;
    count++;
}
Console.WriteLine(newN);

// Через строку
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()!);
string num2 = "";
while (num > 0)
{
    num2 += Convert.ToString(num % 2);
    num = num / 2;
}
for (int i = num2.Length - 1; i >= 0; i--)
{
  Console.Write(num2[i]);
}
// Рефакторинг (убираем for):
Console.WriteLine();
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine()!);
string N2 = "";
while (N > 0)
{
    N2 = Convert.ToString(N % 2) + N2;
    N = N / 2;
}

Console.Write(N2);

// Встроенным методом:
// НЕ РАБОТАЕТ
int number = 4;
Console.WriteLine(Convert.ToString(number, 2));

