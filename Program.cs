string Promt(string message)
{
    Console.WriteLine($"{message}");
    return Console.ReadLine();
}

string[] FillArray(int lenght)
{
    string[] first = new string[lenght];
    for (int i = 0; i < first.Length; i++)
    {
        first[i] = Promt($"Введите строку {i + 1}");
    }
    return first;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"'{array[i]}' ");
}

string[] CreateArray(string[] array)
{
    int counter = 0;
    int signs = 0;
    int TotalCounter = 0;
    int TotalLength = 0;
    while (counter < array.Length)
    {
        foreach (int el in array[counter])
        {
            signs++;
        }
        if (signs <= 3)
        {
            TotalLength++;
        }
        signs = 0;
        counter++;
    }

    string[] TotalArray = new string[TotalLength];
    counter = 0;
    signs = 0;
    TotalCounter = 0;

    while (counter < array.Length)
    {
        foreach (int el in array[counter])
        {
            signs++;
        }
        if (signs <= 3)
        {
            TotalArray[TotalCounter] = array[counter];
            TotalCounter++;
        }
        signs = 0;
        counter++;
    }
    return TotalArray;
}


string UserValue = Promt("Планируется сформировать массив из некоторого количества элементов (слов, цифр, предложений и т.д.). Введите количество элементов в массиве");

if (int.TryParse(UserValue, out var UserLenght))

{
    string[] UserArray = FillArray(UserLenght);

    Console.WriteLine();
    Console.WriteLine("Получился следующий массив строк");

    PrintArray(UserArray);

    string[] ResultArray = CreateArray(UserArray);

    Console.WriteLine();
    Console.WriteLine();


    if (ResultArray.Length < 1)
    {
        Console.WriteLine("В этом массиве нет ни одной строки с длиной меньшей или равной 3. Новый массив пуст");
    }
    else
    {
        Console.WriteLine("Ниже новый массив, состоящий из тех строк первоначального массива, длина которых меньше трех");
        PrintArray(ResultArray);
    }

    Console.WriteLine();
}

else
{
    Console.WriteLine("Некорректный ввод");
}

