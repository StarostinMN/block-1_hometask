/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)*/

Console.Clear();

Console.Write("Введите максимальное количество символов в строке, из которых будет сформирован новый массив: ");
int maxNumberOfChar = Convert.ToInt32(Console.ReadLine());

string?[] strings = FillArrayFromKeybord();
Console.WriteLine();
PrintArray(strings);

string?[] newStrings = GetNewArray(strings, (GetNumberOfChartCount(strings, maxNumberOfChar)), maxNumberOfChar);
PrintArray(newStrings);

string?[] FillArrayFromKeybord()
{
    Console.Write("Введите требуемое количество элементов строкового массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    string?[] ArrayFromKeybord = new string?[n];
    for (int k = 0; k < n; k++)
    {
        Console.Write($"Введите строку {k + 1}: ");
        ArrayFromKeybord[k] = Console.ReadLine();
    }
    return ArrayFromKeybord;
}

int GetNumberOfChartCount(string?[] InputArray, int MaxNumberOfChar)
{
    int numberOfCharCount = 0;
    for (int i = 0; i < InputArray.Length; i++)
    {
        if (InputArray[i].Length <= MaxNumberOfChar)
        {
            numberOfCharCount++;
        }
    }
    return numberOfCharCount;
}

string?[] GetNewArray(string?[] InputArray, int NumberOfCharCount, int MaxNumberOfChar)
{
    int j = 0;
    if (NumberOfCharCount > 0)
    {
        string?[] NewArray = new string?[NumberOfCharCount];
        for (int i = 0; i < InputArray.Length; i++)
        {
            if (InputArray[i].Length <= MaxNumberOfChar)
            {
                NewArray[j] = InputArray[i];
                j++;
            }
        }
        return NewArray;
    }
    else
    {
        string?[] NewArray = new string?[1];
        NewArray[j] = String.Empty;
        return NewArray;
    }
}

void PrintArray(string?[] Array)
{
    Console.Write("[");
    for (int i = 0; i < Array.Length - 1; i++)
    {
        Console.Write((Array[i]) + ", ");
    }
    Console.Write(Array[Array.Length - 1] + "]");
    Console.WriteLine();
}

