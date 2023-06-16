/*
Task 1:
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.WriteLine("Task 1 Fill two-dimensional array:");
void FillDoubleTwoDimensionArray (double[,] array, int numbersOfRows, int numbersOfColumns) {
    Random rand = new Random();
    for (int i = 0; i < numbersOfRows; i++)
    {
        for (int j = 0; j < numbersOfColumns; j++)
        {
            array[i,j] = Math.Round((rand.NextDouble() * rand.Next(-100, 101)), 2);
        }
    }
}
void ShowDoubleArray(double[,] array, int numbersOfRows, int numbersOfColumns) 
{
    for (int i = 0; i < numbersOfRows; i++)
    {
        for (int j = 0; j < numbersOfColumns; j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
int rows = 3, columns = 4;
double[,] array1 =  new double[rows, columns];
FillDoubleTwoDimensionArray(array1, rows, columns);
ShowDoubleArray(array1, rows, columns);

/* Task 2:
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
/*
void CheckElementOfArray(double[,] array, int numbersOfRows, int numbersOfColumns, int inputRow, int inputColumn)
{
    if (inputRow < numbersOfRows && inputColumn < numbersOfColumns)
    {
        Console.WriteLine($"Element on position [{inputRow},{inputColumn}] = {array[inputRow,inputColumn]}");
    }
    else Console.WriteLine("Your element doesn't exist.");
}
Console.WriteLine("Task 2 Check an element of array:");
Console.Write("Enter a row of your number: ");
int inputRow = int.Parse(Console.ReadLine());
Console.Write("Enter a column of your number: ");
int inputColumn = int.Parse(Console.ReadLine());
CheckElementOfArray(array1, rows, columns, inputRow, inputColumn);
*/
/*
Task 3: 
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 */
Console.WriteLine("Task 3 Average of columns:");
void FillIntTwoDimensionArray(int[,] array, int numbersOfRows, int numbersOfColumns)
{
    Random rand = new Random();
    for (int i = 0; i < numbersOfRows; i++)
    {
        for (int j = 0; j < numbersOfColumns; j++)
        {
            array[i, j] = rand.Next(-100, 101);
        }
    }
}
void ShowIntArray(int[,] array, int numbersOfRows, int numbersOfColumns)
{
    for (int i = 0; i < numbersOfRows; i++)
    {
        for (int j = 0; j < numbersOfColumns; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void AverageOfNumbersOfArray (int[,] array, int numbersOfRows, int numbersOfColumns)
{
   double average = 0;
    for (int i = 0; i < numbersOfColumns; i++)
    {
        average = 0;
        for (int j = 0; j < numbersOfRows; j++)
        {
            average += array[j, i];
        }
        Console.WriteLine($"Average of {i} column = {Math.Round((average /= numbersOfRows), 2)}"); 
    }
}
int[,] array2 = new int[rows, columns];
FillIntTwoDimensionArray(array2, rows, columns);
ShowIntArray(array2, rows, columns);
AverageOfNumbersOfArray(array2, rows, columns);
