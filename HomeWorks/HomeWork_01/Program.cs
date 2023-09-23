// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Задача 2.");
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
if(a > b) Console.WriteLine($"Первое число ({a}) больше второго ({b}).");
else if(a < b) Console.WriteLine($"Первое число ({a}) меньше второго ({b}).");
else Console.WriteLine($"Первое число ({a}) равно второму ({b}).");
Console.WriteLine();

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Задача 4.");
Console.Write("Введите первое число: ");
int n1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int n2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int n3 = int.Parse(Console.ReadLine()!);
int max = n1;
if (n2 > max) max = n2;
if (n3 > max) max = n3;
Console.WriteLine($"{max} - максимальное из трёх чисел.");
Console.WriteLine();

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Задача 6.");
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if (number % 2 == 0) Console.Write("Вы ввели чётное число.");
else Console.WriteLine("Вы ввели нечётное число.");
Console.WriteLine();

// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Задача 8.");
Console.Write("Введите число больше 1: ");
int num = int.Parse(Console.ReadLine()!);
if (num <= 1) Console.Write("Вы ввели неверное число.");
else {
    int index = 2;
    Console.Write($"Чётные числа от 1 до {num}: ");
    while (index <= num){
        Console.Write($"{index} ");
        index += 2;
    }
}
Console.WriteLine();

