Console.Clear();
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Write("Enter first number: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Enter second number: ");
int b = int.Parse(Console.ReadLine()!);
if (a > b) {
    Console.WriteLine($"Max = {a}");
}
else {
    Console.WriteLine($"Max = {b}");
}
Console.WriteLine("--------------");

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Enter first number: ");
int first = int.Parse(Console.ReadLine()!);
Console.Write("Enter second number: ");
int second = int.Parse(Console.ReadLine()!);
Console.Write("Enter third number: ");
int third = int.Parse(Console.ReadLine()!);
int max = first;
if (max < second) {
    max = second;
}
if (max < third) {
    max = third;
}
Console.WriteLine($"Max = {max}");
Console.WriteLine("--------------");
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine()!);
if (num % 2 == 0) {
    Console.WriteLine($"{num} is even");
}
else {
    Console.WriteLine($"{num} is odd");
}
Console.WriteLine("--------------");
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Enter number: ");
int N = int.Parse(Console.ReadLine()!);
int count = 1;
Console.Write($"All even numbers from 1 to {N}: ");
while (count <= N) {
    if (count % 2 == 0) {
        Console.Write($"{count} ");
    
    }
    count ++;
}
