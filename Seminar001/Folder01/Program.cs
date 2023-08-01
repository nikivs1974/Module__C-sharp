Console.Clear();
Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine()!);
// Математически
int sqr = number * number;
Console.WriteLine($"Sqr number {number} = {sqr}");

// Библиотека
int sqr2 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Sqr {number} = {sqr2} ---> Библиотека");

// Принимает 2 числа и определяет, является ли первое квадратом второго
