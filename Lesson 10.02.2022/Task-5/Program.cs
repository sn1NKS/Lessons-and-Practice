﻿// Задать массив из 8 элементов и вывести их на экран.
int[] mas = {1,2,3,4,5,6,7,8};
void Function(int[] array)
{
    for (int i = 0;i < array.Length;i++)
    Console.WriteLine(array[i]);
}
Function(mas);