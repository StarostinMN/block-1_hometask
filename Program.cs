﻿/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)
 */

Console.Clear();

Console.Write("Введите максимальное количество символов в строке, из которых будет сформирован новый массив: ");
int maxNumberOfChar = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetNumberOfChartCount(FillArrayFromKeybord(), maxNumberOfChar));

string?[] FillArrayFromKeybord()
{
    Console.Write("Введите требуемое количество элементов строкового массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    string?[] InputArrayFromKeybord = new string?[n];
    for (int k = 0; k < n; k++)
    {
        Console.Write($"Введите строку {k + 1}: ");
        InputArrayFromKeybord[k] = Console.ReadLine();
    }
    return InputArrayFromKeybord;
}

int GetNumberOfChartCount(string?[] strings, int MaxNumberOfChar)
{
    int NumberOfCharCount = 0;
    for (int i = 0; i < strings.Length; i++)
    {
        if (strings[i].Length <= MaxNumberOfChar)
        {
            NumberOfCharCount++;
        }
    }
    return NumberOfCharCount;
}

