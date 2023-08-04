// Счастливое число
// Счастливое число - сумма первых трёх цифр равна сумме вторых трёх цифр
// 123321 yes
// 181505 yes
// 123456 no

// Мой вариант

Console.Write("Введите 6-и значное число: ");
string number = Console.ReadLine()!;

bool HappyNum(string number)
{
    int left = int.Parse($"{number[0]}") + int.Parse($"{number[1]}") + int.Parse($"{number[2]}");
    int right = int.Parse($"{number[3]}") + int.Parse($"{number[4]}") + int.Parse($"{number[5]}");
    bool result = false;
    if (left == right)
    {
        result = true;
    }
    return result;
}
Console.WriteLine(HappyNum(number));


// Вариант с семинара
Console.Write("Enter ****** number: ");
int N = int.Parse(Console.ReadLine()!);
if (N >= 100000 && N <= 999999)
{
    if (LuckyNumber(N) == true)
    {
        Console.WriteLine($"Number {N} is Lucky");
    }
    else
    {
        Console.WriteLine($"Number {N} NOT Lucky");
    }
}
else
{
        Console.WriteLine($"No correct Enter");
}

bool LuckyNumber(int num)
{
    string number = num.ToString();
    int left = (Convert.ToInt32(number[0]) + Convert.ToInt32(number[1]) + Convert.ToInt32(number[2]));
    int right = (Convert.ToInt32(number[3]) + Convert.ToInt32(number[4]) + Convert.ToInt32(number[5]));
    Console.WriteLine(left);
    Console.WriteLine(right);
    if (left == right)
    {
        return true;
    }
    return false;
}
