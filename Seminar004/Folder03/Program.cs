// Счастливое число
// Счастливое число - сумма первых трёх цифр равна сумме вторых трёх цифр
// 123321 yes
// 181505 yes
// 123456 no

// Вариант 3. Сочетание методов

// 1. Запрос 6-и значного числа
string PutNumber()
{
    Console.Write("Введите шестизначное число: ");
    string result = Console.ReadLine()!;
    return result;
}

// 2. Проверка на 6-и значность
bool Check(string num)
{
    if (num.Length == 6) return true;
    else return false;
}
// 3. Happy method
void FindHappy(string num)
{
    if (num[0] + num[1] + num[2] == num[3] + num[4] + num[5])
    {
    Console.WriteLine("Happy number!");
    }
    else 
    { 
    Console.WriteLine("NOT Happy number!");
    }
}

// 4. Программа
string number = PutNumber();
if (Check(number)) FindHappy(number);
else Console.WriteLine("Number in not valid");