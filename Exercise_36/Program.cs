﻿// Задайте одномерный массив, заполненный случайными 
// числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] array = new int [4];
int size = array.Length;
int sum = 0;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-99,100);

    if (i%2 == 1)
    {
        sum+=array[i];
    }
}
Console.WriteLine("[{0}]", String.Join(",", array));
Console.WriteLine(sum);