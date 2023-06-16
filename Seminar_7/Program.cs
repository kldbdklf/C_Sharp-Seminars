/*
Task 1:
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
Console.WriteLine("Task 1 Fill two-dimensional array:");
void FillTwoDimensionArray (double[,] array, int numbersOfRows, int numbersOfColumns) {
    Random rand = new Random();
    for (int i = 0; i < numbersOfRows; i++)
    {
        for (int j = 0; j < numbersOfColumns; j++)
        {
            array[i,j] = Math.Round((rand.NextDouble() * rand.Next(-100, 101)), 2);
        }
    }
}
void ShowArray(double[,] array, int numbersOfRows, int numbersOfColumns) 
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
FillTwoDimensionArray(array1, rows, columns);
ShowArray(array1, rows, columns);