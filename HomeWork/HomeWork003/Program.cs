// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// (первое == последнему, второе == предпоследнему).
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Write("Введите 5-и значное число: ");
string palindrome = (Console.ReadLine()!);
if (palindrome.Length != 5){

Console.Write("Введено не 5-и значное число!\n\n");
}
else if (palindrome[0] == palindrome[4] && palindrome[1] == palindrome[3]){
    
Console.Write($"{palindrome} is palindrome\n\n");
}
else {
  Console.Write($"{palindrome} is NOT palindrome\n\n");  
}

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

Console.Write("Enter AX: ");
int ax = int.Parse(Console.ReadLine()!);
Console.Write("Enter AY: ");
int ay = int.Parse(Console.ReadLine()!);
Console.Write("Enter AZ: ");
int az = int.Parse(Console.ReadLine()!);

Console.Write("Enter BX: ");
int bx = int.Parse(Console.ReadLine()!);
Console.Write("Enter BY: ");
int by = int.Parse(Console.ReadLine()!);
Console.Write("Enter BZ: ");
int bz = int.Parse(Console.ReadLine()!);

double ab = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
Console.Write($"Расстояние между точкой A ({ax},{ay},{az}) и точкой B ({bx},{by},{bz}) в 3D пространстве равно {ab:f2}\n\n");




// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Enter N: ");
int numberN = int.Parse(Console.ReadLine()!);
int count = 1;
Console.Write($"Таблица кубов чисел от 1 до {numberN}: ");
while (count <= numberN){
    Console.Write($"{Math.Pow(count, 3)} ");
    count ++;
}
