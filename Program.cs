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
        first[i] = Promt($"Введите строку {i}");
    }
    return first;
}

Console.WriteLine("Планируется сформировать массив из некоторого количества элементов (слов, цифр, предложений и т.д.). На данном этапе необходимо определить, сколько в этом массиве будет элементов. Введите количество элементов в массиве");
int UserLenght =  Console.ReadLine();