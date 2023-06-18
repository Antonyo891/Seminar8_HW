/*Задача 56: Задайте прямоугольный двумерный массив.
 Напишите программу, которая будет находить строку с
  наименьшей суммой элементов.*/
using System;
using static System.Console;
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($" {array[i, j]} ");
        }
        WriteLine();
    }
}
int[,] GetArray(int line, int column) // создает двумерный массив с рандомными элементами
{
    int[,] result = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++) result[i, j] = new Random().Next(10);
    }
    return result;
}
int FindMinLineSum(int[,] array)
{
    int l = 0, result = 0;
    int[] sum = { 0, 0 };
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum[l] = 0;
        for (int j = 0; j < array.GetLength(1); j++) sum[l] += array[i, j];
        if (l == 1 && sum[0] > sum[1])
        {
            sum[0] = sum[1];
            result = i;
        }
        else if (l<1) l++;
    }
    return result;
}
Clear();
int[,] array = GetArray(7,5);
PrintArray(array);
WriteLine($"Минимальная сумма элементов в строке массива с индексом {FindMinLineSum(array)}");