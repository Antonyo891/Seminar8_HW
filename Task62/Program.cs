/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.*/
using System;
using static System.Console;
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int position = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            position += 6;
            SetCursorPosition(position, i+1);
            Write($"   {array[i, j]}");
        }
        WriteLine();
    }
}
int [,] ArraySpiralFilling(int line, int column)
{
int[,] array = new int[line, column];
array[0,0]=1;
int i = 0, j = 1, count = 2, maxLine = line, maxColumn = column;
int startLine=0,startColumn=0;
    while (count <= line*column)
        if (j < maxColumn - 1&&i==startLine&&j>startColumn)
        {
            array[i, j] = count;
            j++;
            count++;

        } 
        else if (j==maxColumn-1&&i==startLine&&i==0)
        {
            array[i, j] = count;
            i++;
            count++;
        }
        else if (j == maxColumn - 1&&i<maxLine-1&&i>startLine)
        {
            array[i, j] = count;
            i++;
            count++;
        }
        else if  (i==maxLine-1&&j==maxColumn-1)
        {
            array[i, j] = count;
            j--;
            startLine++;
            count++;
        } 
        else if (i==maxLine-1&&j>startColumn&&j<maxColumn-1)
        {
            array[i, j] = count;
            j--;
            count++;
        }
        else if (i==maxLine-1&&j==startColumn)
        {
            array[i, j] = count;
            i--;
            maxColumn--;
            count++;
        }
        else if (j==startColumn&&i<maxLine-1&&i>startLine)
         {
            array[i, j] = count;
            i--;
            count++;
        }
        else if (j==startColumn&&i==startLine)
         {
            array[i, j] = count;
            j++;
            maxLine--;
            count++;
        }  
        else if (j==maxColumn-1&&i==startLine&&i>0)
        {
            array[i, j] = count;
            i++;
            startColumn++;
            count++;
        }
return array;}
Clear();
int [,] array = ArraySpiralFilling(4,4);
PrintArray(array);