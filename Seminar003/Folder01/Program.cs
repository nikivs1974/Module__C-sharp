Console.Write("Enter: ");
int number = int.Parse(Console.ReadLine()!);
switch (number)
{
    case 6:
        {

            Console.WriteLine("Yes 6");
            break;

        }
    default:
        {

            Console.WriteLine("No");
            break;
        }

}

// Проверка что введенное число трехзначное
Console.Write("Enter number ***:");
string StrNum = (Console.ReadLine()!);
switch (StrNum.Length)
{
    case 3:
        {
            Console.Write($"{StrNum} is ***");
            break;
        }


    default:
        {
            Console.Write($"{StrNum} is NOT ***");
            break;

        }
}










