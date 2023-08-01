// Ex1--> Ввести номер четверти. Программа показывает диапазон координат точек (x и y)
// 1 --> X > 0, Y > 0
// 2 --> X < 0, Y > 0
// 3 --> X < 0, Y < 0
// 4 --> X > 0, Y < 0
Console.Write("Enter number 1/4: ");
int numSqr = int.Parse(Console.ReadLine()!);
switch (numSqr)
{
    case 1:
        {
            Console.WriteLine($"{numSqr} is X > 0, Y > 0");
            break;
        }
    case 2:
        {
            Console.WriteLine($"{numSqr} is X < 0, Y > 0");
            break;
        }
    case 3:
        {
            Console.WriteLine($"{numSqr} is X < 0, Y < 0");
            break;
        }
    case 4:
        {
            Console.WriteLine($"{numSqr} is X > 0, Y < 0");
            break;
        }

    default:
        {
            Console.WriteLine($"{numSqr} is not number 1/4");
            break;
        }
}

// Ex2--> Принимает на вход координаты 2 точек и находит расстояние между ними в 2D пространстве
// А (3,6) B (2,1) --> 5,09
// А (7,-5) B (1,-1) --> 7,21
// AB = √(xb - xa)2 + (yb - ya)2
Console.Write("Enter AX: ");
int ax = int.Parse(Console.ReadLine()!);
Console.Write("Enter AY: ");
int ay = int.Parse(Console.ReadLine()!);
Console.Write("Enter BX: ");
int bx = int.Parse(Console.ReadLine()!);
Console.Write("Enter BY: ");
int by = int.Parse(Console.ReadLine()!);
double ab = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
Console.WriteLine($"{ab:f2}");


// Ex3--> Принимает N и выдает таблицу квадратов от 1 до N
Console.Write("Enter N: ");
int N = int.Parse(Console.ReadLine()!);
int count = 1;
while (count <= N)
{
    Console.Write($"{Math.Pow(count, 2)} ");
    count++;

}