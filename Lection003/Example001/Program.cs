// 1. Ничего не принимают, ничего не возвращают
void Method01()
{
    Console.WriteLine("My name is Nikolay\n");
}
Method01();
// 2. Что-то принимают, но ничего не возвращают
void Method02(string a)
{
    Console.WriteLine(a);
}
// Именованные аргументы (удобно, когда их много)
Method02(a: "Hello\n");

void Method021(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.Write(msg);
        i++;
    }
}
Method021(count:3, msg: "Text ");
Console.WriteLine("\n");

// 3. Ничего не принимают, что-то возвращают
int Method03()
{
    return DateTime.Now.Year;
}
int year = Method03();
Console.WriteLine(year);
Console.WriteLine("\n");


// 4. Принимают и возвращают
string Method04(int count, string text)
{
    string result = String.Empty; // Создание пустой строки
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string s = Method04(3, "Hello ");
Console.Write(s);
Console.WriteLine("\n");


// Цикл в цикле. Таблица умножения
Console.WriteLine("Таблица умножения:");
void TableMultiplay()
{
    for(int i = 2; i <= 10; i++)
    {
        for(int j = 2; j <= 10; j++)
        {
            Console.WriteLine($"{i} * {j} = {i*j}");
        }
        Console.WriteLine("");
    }
}
TableMultiplay();


// Нужно заменить все пробелы заменить черточками. Маленькие к большими. А большие С маленькими.
string text = "23 августа к Земле на расстояние 6,08 млн км (0,04065 астрономических единиц)"
                + " приблизится астероид 6037 (1988 EG), следует из данных NASA.";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    for(int i = 0; i < text.Length; i++)
    {
        if(text[i] == oldValue)
        {
            result = result + $"{newValue}";
        }
        else
        {
            result = result + $"{text[i]}";
        }
    }

    return result;
}
string newText = Replace(text, ' ', '_');
Console.WriteLine(newText);
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

// Сортировка массива методом выбора. 
// 1. Найти позицию минимального элемента в неотсортированной части массива
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции
// 3. Повторять пока есть неотсортированные элементы
int[] GetSort(int[] unsort)
{
    int[] result = new int[unsort.Length];
    int min = unsort[0];
    int count = 0;
    for(int i = 0; i < unsort.Length; i++)
    {
        result[i] = unsort[i];
        if(result[i] < min)
        {
            min = result[i];
            result[count] = result[i];
            result[i] = unsort[count];
            count++;
        }
     
            
        
    }
    return result;
}
int[] unsort = {2, 3, 1, 4};
int[] array = GetSort(unsort);
Console.WriteLine($"{String.Join(",", array)}");