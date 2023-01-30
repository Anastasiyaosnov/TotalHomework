string Promt(string massage)
{
    Console.WriteLine($"{massage}");
    return Console.ReadLine();
}

string[] CreateArray(int lenght)
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

Console.WriteLine("Планируется сформировать массив из некоторого количества элементов (слов, цифр, предложений и т.д.). На данном этапе необходимо определить, сколько в этом массиве будет элементов. Введите количество элементов в массиве");
int UserLenght =  Convert.ToInt32(Console.ReadLine());

string[] UserArray = CreateArray(UserLenght);

Console.WriteLine("Получился следующий массив строк");

PrintArray(UserArray);

