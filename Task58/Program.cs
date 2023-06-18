/*Задача 58: Задайте две матрицы. Напишите программу,
 которая будет находить произведение двух матриц.*/
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
int[,] MultiplyArray(int[,] array, int[,] array1)
{
    int line1 = array.GetLength(0);
    int line2 = array1.GetLength(0);
    int column1 = array.GetLength(1);
    int column2 = array1.GetLength(1);
    int column3 = column2;
    int line3 = line1;
    int[,] result = new int[line3, column3];
    for (int i = 0; i < line3; i++)
        for (int j = 0; j < column3; j++)
            for (int k = 0; k < column1; k++) result[i, j] += array[i, k] * array1[k, j];
    return result;
}
Clear();
int[,] array = GetArray(3, 3);
int[,] array1 = GetArray(3, 4);
PrintArray(array);
PrintArray(array1);
if (array.GetLength(1) == array1.GetLength(0))
{
    WriteLine($"Произведение матриц это матрица ==>");
    PrintArray(MultiplyArray(array,array1));
}
else WriteLine("Данные матрицы нельзя перемножить");