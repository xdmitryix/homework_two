﻿int array = { 1, 12, 31, 31, 15, 16, 17, 18 };

int n = array.Lengtn;
int find = 4;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}