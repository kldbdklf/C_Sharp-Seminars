﻿/*
 Task 1: 
Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
 */

using Microsoft.VisualBasic;

Console.WriteLine("Task 1 Sum of main diagonal: ");
void FillIntMatrix(int[,] matrix)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(-10, 11);
        }
    }
}
void ShowIntArray (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
void ShowSumDiagonal (int[,] matrix)
{
    int result = 0;
    for (int i = 0, j = 0; i < matrix.GetLength(0) && j < matrix.GetLength(1); i++, j++)
    {
        result += matrix[i, j];
    }
    Console.WriteLine($"Sum of diagonal = {result}");
}
int[,] matrix1 = new int[5, 5];
//FillIntMatrix(matrix1);
//ShowIntArray(matrix1);
// ShowSumDiagonal(matrix1);

/*
 Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
 */
Console.WriteLine("Task 2 Sort of rows: ");
void SortRows(int[,] matrix)
{
 
    for (int i = 0; i < matrix.GetLength(0);i++)
    {
        int temp = 0;
        for (int k = 1; k < matrix.GetLength(1) - 1; k++)
        {
            for (int j = 0; j < matrix.GetLength(1) - k; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = temp;
                }
            }
        }
    }
}
//SortRows(matrix1);
//ShowIntArray(matrix1);
/* 
Task 3:
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
 */

Console.WriteLine("Task 3 Min of rows: ");
void FindMinRow(int[,] matrix)
{
    int min = 0, indexMin = 0;
    bool flag = true; // Я упорно не хотел делать массив с суммами чисел строк, поэтому придумал такой флаг, чтобы произошло первое присвоение min = sum
    for  (int i = 0;i < matrix.GetLength(0);i++)
    {
        int sum = 0; 
        for (int  j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (min > sum || flag)
        {
            min = sum;
            indexMin = i;
            flag = false;
        }
    }
    Console.WriteLine($"Min sum of number found in row {indexMin}");
}

int[,] matrix2 = new int[3, 4];
FillIntMatrix(matrix2);
ShowIntArray(matrix2);
FindMinRow(matrix2);
