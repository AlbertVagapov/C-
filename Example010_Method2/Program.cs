﻿int[] array = { 3, 5, 86, 9, 4, 7, 35, 86 };

int n = array.Length;
int find = 86;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}