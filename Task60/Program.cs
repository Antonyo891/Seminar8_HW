/*Задача 60: Сформируйте трёхмерный массив из 
неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.*/
using System;
using static System.Console;
void PrintArrayWhithIndex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write("[");
            for (int k = 0; k < array.GetLength(2); k++)
                Write($"({i};{j};{k})=>{array[i, j, k]}");
            Write("]");
        }
        WriteLine();
    }
}
int[,,] GetArrayRandomOnce(int index1, int index2, int index3) // создает трехмерный массив с рандомными элементами
{
    int[] onceCheck = new int[index1 * index2 * index3];
    int[,,] result = new int[index1, index2, index3];
    int m=0, count = 0;
    for (int i = 0; i < index1; i++)
        for (int j = 0; j < index2; j++)
            for (int k = 0; k < index3; k++)
            {
                result[i, j, k] = new Random().Next(8);
                onceCheck[m] = result[i, j, k];
                Write($" m = {m} -result[{i},{j},{k}] - {result[i, j, k]} ");
                if (m == 0) WriteLine($" onceCheck[{m}]-{onceCheck[m]} result[{i}, {j}, {k}] - {result[i, j, k]} ");
                for (int l = 0; l < m; l++)
                {
                    WriteLine($"Цикл l = {l} onceCheck[{l}]-{onceCheck[l]} <=> result[{i}, {j}, {k}] - {result[i, j, k]} ");
                    if (result[i, j, k] == onceCheck[l])
                    {
                        Write($"Заменяем result[{i}, {j}, {k}] = на {result[i, j, k]}");
                        result[i, j, k] = new Random().Next(8);
                        WriteLine(result[i, j, k]);
                        onceCheck[m] = result[i, j, k];
                        l = -1;
                    }
                }
                m++;
            }
    return result;
}
Clear();
int[,,] array = GetArrayRandomOnce(2, 2, 2);
PrintArrayWhithIndex(array);