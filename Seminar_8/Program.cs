/*
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
void ShowIntArray(int[,] matrix)
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
void ShowSumDiagonal(int[,] matrix)
{
    int result = 0;
    for (int i = 0, j = 0; i < matrix.GetLength(0) && j < matrix.GetLength(1); i++, j++)
    {
        result += matrix[i, j];
    }
    Console.WriteLine($"Sum of diagonal = {result}");
}
int[,] matrix1 = new int[5, 5];
FillIntMatrix(matrix1);
ShowIntArray(matrix1);
ShowSumDiagonal(matrix1);
Console.WriteLine();

/*
Task 2:
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

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp = 0;
        for (int k = 1; k < matrix.GetLength(1); k++)
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
SortRows(matrix1);
ShowIntArray(matrix1);
Console.WriteLine();
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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
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
Console.WriteLine();

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.WriteLine("Task 4 Multiplication of matrix: ");
int[,] GetResultMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix2.GetLength(1); i++)
    {
        for (int j = 0; j < matrix1.GetLength(0); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                resultMatrix[j, i] += matrix1[j, k] * matrix2[k, i];
            }
        }
    }
    return resultMatrix;
}
void FillIntMatrixByUser(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"Enter element of matrix with index [{i},{j}] : ");
            matrix[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

Console.WriteLine("Enter number of rows of first matrix: ");
int rowsFirstMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of columns of first matrix and rows of second matrix: ");
int columnsFirstMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of columns of second matrix: ");
int columnsSecondMatrix = Convert.ToInt32(Console.ReadLine());
int[,] matrix3 = new int[rowsFirstMatrix, columnsFirstMatrix];
int[,] matrix4 = new int[columnsFirstMatrix, columnsSecondMatrix];
Console.WriteLine("Fill the first matrix: ");
FillIntMatrixByUser(matrix3); 
Console.WriteLine("Fill the second matrix: ");
FillIntMatrixByUser(matrix4);
int[,] resultMatrix = GetResultMultiplication(matrix3, matrix4);
Console.WriteLine("First matrix: ");
ShowIntArray(matrix3);
Console.WriteLine("Second matrix: ");
ShowIntArray(matrix4);
Console.WriteLine("Result of multiplication: ");
ShowIntArray(resultMatrix);
Console.WriteLine();

/*
Task 5:
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

Console.WriteLine("Task 5 Unique 3D array: ");
bool CheckUnique(int[,,] Array3D, int lastRow, int lastColumn, int lastDepth)
{
    for (int i = 0; i < Array3D.GetLength(0); i++)
    {
        for (int j = 0; j < Array3D.GetLength(1); j++)
        {
            for (int k = 0; k < Array3D.GetLength(2); k++)
            {
                if (lastRow == i && lastColumn == j && lastDepth == k) { }
                else if (Array3D[lastRow, lastColumn, lastDepth] == Array3D[i, j, k]) return true;
            }
        }
    }
    return false;
}
void FillInt3DArray(int[,,] Array3D)
{
    Random rand = new Random();
    bool duplicate = true;
    for (int i = 0; i < Array3D.GetLength(0); i++)
    {
        for (int j = 0; j < Array3D.GetLength(1); j++)
        {
            for (int k = 0; k < Array3D.GetLength(2); k++)
            {
                duplicate = true;
                do
                {
                    Array3D[i, j, k] = rand.Next(10, 101);
                    duplicate = CheckUnique(Array3D, i, j, k);
                } while (duplicate);
            }
        }
    }
}
void ShowInt3DArray(int[,,] Array3D)
{
    for (int i = 0; i < Array3D.GetLength(0); i++)
    {
        for (int j = 0; j < Array3D.GetLength(1); j++)
        {
            for (int k = 0; k < Array3D.GetLength(2); k++)
            {
                Console.Write($"{Array3D[i, j, k]}({i}, {j}, {k}) | ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
int[,,] Array3D = new int[3, 3, 3];
FillInt3DArray (Array3D);
ShowInt3DArray(Array3D);
Console.WriteLine();
/*
Task 6
ДОПОЛНИТЕЛЬНАЯ. Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
 */
Console.WriteLine("Task 6 Spiral filling: ");
// Код довольно специфический, но работает для всех случаев. Независимо от размера и формы матрицы все будет заполнено.
// Далее оставил комментарии, чтобы было понятнее
bool IsEven(int x)
{
    if (x % 2 == 0) return true;
    return false;
}
void FillSpiralIntMatrix(int[,] matrix) // метод заполняет матрицу кругами, начиная с внешнего и заканчивая внутренним. 
{
    int counter = 1, i = 0, j = 0, numberOfRepeat = 0;
    bool flagIsEven = IsEven(matrix.GetLength(0));
    // counter - само число, которое присваивается элементам матрицы, а также используется для проверки окончания всего процесса заполнения
    // i - итератор по строкам, j - итератор по столбцам - мне требовалась их видимость для всей функции, поэтому я объявил их вне цикла for
    // numberOfRepeat - количество кругов, которые нужно заполнить в матрице
    // количество кругов определяется if else, в соответствии со следующей логикой: 
    // если число строк четное, то число строк делится на 2
    // если число строк нечетное, то добавляется дополнительный круг
    // при этом, если количество строк больше количества столбцов т.е. матрица представляет собой вертикальный прямоугольник,
    // то даже при нечетном количестве строк дополнительный круг будет лишним
    if (flagIsEven || matrix.GetLength(0) > matrix.GetLength(1)) numberOfRepeat = matrix.GetLength(0) / 2; 
    else numberOfRepeat = matrix.GetLength(0) / 2 + 1;
    for (int k = 0; k < numberOfRepeat; k++) // k - итератор, который реализует количество повторений, а также позволяет отсечь круги, которые уже были пройдены
    {
        i = k; // отсечение пройденных кругов
        j = k;
        for (; j != matrix.GetLength(1) - k - 1; j++, counter++) // проходим верхнюю строку
        {
            // далее представлен костыль, который позволяет применять алгоритм к матрицам с разрывом между количеством строк и столбцов больше 1
            // без него последняя строка в таких массивах перезаписывает саму себя
            if (counter == matrix.GetLength(0) * matrix.GetLength(1) + 1) break; 
            matrix[i, j] = counter;
        }
        for (; i != matrix.GetLength(0) - k - 1; i++, counter++) // проходим правый столбец
        {
            if (counter == matrix.GetLength(0) * matrix.GetLength(1) + 1) break;
            matrix[i, j] = counter;
        }
        for (; j != k; j--, counter++) // проходим нижнюю строку
        {
            if (counter == matrix.GetLength(0) * matrix.GetLength(1) + 1) break;
            matrix[i, j] = counter;
        }
        for (; i != k; i--, counter++) // проходим левый столбец
        {
            if (counter == matrix.GetLength(0) * matrix.GetLength(1) + 1) break;
            matrix[i, j] = counter;
        }
        if (counter == matrix.GetLength(0) * matrix.GetLength(1) + 1) break;
        if (!flagIsEven && k == numberOfRepeat - 1 ) // вставляет число в центральный элемент матрицы, у которой нечетное количество строк
        {
            matrix[i, j] = counter;
        }
        if (counter == matrix.GetLength(0) * matrix.GetLength(1) + 1) break;
    }
}
int[,] matrix5 = new int[10,6];
FillSpiralIntMatrix(matrix5);
ShowIntArray(matrix5);


