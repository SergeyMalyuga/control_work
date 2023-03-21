﻿/* Написать программу, которая из имеющегося массива из строк,
длина которых меньше либо равна 3 символа. Первоночальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.*/

int FindLength(String[] array) // определение длинны нового массива
{
    int count=0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            count += 1;
        }
    
    return count;
}

String[] NewArray(String[] array, int count) // создание нового массива из имеющегося
{
    String[] array2 = new String[count];
    int j=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[j]=array[i];
            j++;
        }
    }
    return array2;
}

String[] array = { "stop", "bus", "cry", "2", "hi" };
int count = FindLength (array);
String[] array2 = NewArray(array, count);
Console.WriteLine ($" [{String.Join(",", array)}] -> [{String.Join(",", array2)}]");
