string Promt(string massage)
{
    Console.WriteLine($"{massage}");
    return Console.ReadLine();
}

string[] FillArray(int lenght)
{
    string[] first = new string[lenght];
    for (int i = 0; i < first.Length; i++)
    {
        first[i] = Promt($"Введите строку {i+1}");
    }
    return first;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"'{array[i]}' ");
}

string [] CreateArray (string[] array)
{
    string[] TotalArray = new string[array.Length];
    int counter = 0;
    int signs = 0;
    int TotalCounter = 0;
    while (counter < TotalArray.Length)
    {
        foreach(int el in array[counter])
        {
            signs ++; 
        }
        if(signs<= 3)
        {
            TotalArray[TotalCounter] = array[counter];
            TotalCounter ++;
        }
        signs = 0;
        counter++;
    }
    return TotalArray;
}



Console.WriteLine("Планируется сформировать массив из некоторого количества элементов (слов, цифр, предложений и т.д.). На данном этапе необходимо определить, сколько в этом массиве будет элементов. Введите количество элементов в массиве");
int UserLenght =  Convert.ToInt32(Console.ReadLine());

string[] UserArray = FillArray(UserLenght);

Console.WriteLine("Получился следующий массив строк");

PrintArray(UserArray);

string[] ResultArray = CreateArray(UserArray);

Console.WriteLine();

PrintArray(ResultArray);
