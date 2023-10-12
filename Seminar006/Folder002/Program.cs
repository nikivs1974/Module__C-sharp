// Принимает на вход 3 числа и проверяет может ли существовать треугольник с сторонами такой длины
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон
Console.Write("Введите первую сторону треугольника: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите вторую сторону треугольника: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите третью сторону треугольника: ");
int c = int.Parse(Console.ReadLine()!);

bool Trigon(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
        return true;
    else
        return false;
}
Console.Write(Trigon(a, b, c));



