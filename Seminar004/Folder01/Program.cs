// Принимает на вход число (A) и выдаёт сумму чисел от 1 до A
Console.Write("Enter A: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел от 1 до {a} = {GetSum(a)}");
int GetSum(int a)
{
    int result = 0;
    for (int i = 1; i <= a; i++)
    {
        result += i;   
    }
    return result;
}


// Принимает на вход число (N) и выдаёт произведение чисел от 1 до N
// 4 -> 24
// 5 -> 120
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Произведение чисел от 1 до {N} = {GetMultiplay(N)}");
int GetMultiplay(int N)
{
    int result = 1;
    for(int i=1; i <= N; i++)
    {
        result *= i;
    }
    return result;
}


// Палиндром (HW003, переписанный через метод) 
bool GetPoli(string poli)
{
    bool result = false;
    if (poli[0] == poli[4] && poli[1] == poli[3])
    {
        result = true;
    }
    return result;
}
Console.WriteLine(GetPoli("12328"));



