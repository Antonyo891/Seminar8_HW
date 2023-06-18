/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.*/
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
void SortingLineOfArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = array.GetLength(1) - 1; k > j; k--)
            {
                if (array[i, k] > array[i,k - 1])
                {
                    int save = array[i,k];
                    array[i,k] = array[i,k - 1];
                    array[i,k - 1] = save;
                }
            }
}
Clear();
int[,] array = GetArray(10, 10);
PrintArray(array);
SortingLineOfArray(array);
WriteLine();
ReadLine();
PrintArray(array);