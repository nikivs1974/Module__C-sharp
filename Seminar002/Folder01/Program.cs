// Принимает случайное трёхзначное, и удаляет их него вторую цифру
// 456 -> 46
int num = new Random().Next(1000);
string NumStr = num.ToString();

if (NumStr.Length == 3)
{
    Console.WriteLine($"Число {num} без втророй цифры: {NumStr[0]}{NumStr[2]}");
}
else
{
    Console.WriteLine($"Число {num} не трехзначное");
}

// Выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа
// 15 -> 5
int num2 = new Random().Next(10, 100);
string NumStr2 = num2.ToString();

if (Convert.ToInt32(NumStr2[0]) > Convert.ToInt32(NumStr2[1]))
{
    Console.WriteLine($"{NumStr2[0]} большее в числе {num2}");
}
else
{
    Console.WriteLine($"{NumStr2[1]} большее в числе {num2}");
}

// Принимает 2 числа и выводит является ли второе кратным первому.
// 34 и 5 не кратно, остаток 5
// 16 и 4 кратно
int num3 = new Random().Next(10, 100);
int num4 = new Random().Next(1, 10);
if (num3%num4 == 0){
    Console.WriteLine($"{num3} и {num4} - кратные числа");
}
else {
    Console.WriteLine($"{num3} и {num4} - не кратные числа. Остаток {num3%num4}");
}
// Принимает число и проверяет кратнео ли оно одновременно 7 и 23
// 161 да
int num5 = new Random().Next(1, 1000);
if (num5 % 7 == 0 && num5 % 23 == 0) {
    Console.WriteLine($"{num5} кратно 7 и 23");
}
else {
    Console.WriteLine($"{num5} не кратно 7 и 23");
}
// Принимает 2 числа и определяет является ли одно квадратом другого
