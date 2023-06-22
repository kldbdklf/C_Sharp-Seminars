/*
 Task 1:
 Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
 */
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Task 1 Natural numbers in the range from N to 1:");
string GetNumbersString (int N)
{
    string result = String.Empty;
    if (N == 1) return N.ToString();
    return N + ", " + GetNumbersString(N - 1);
}
/*
Console.Write("Enter N: ");
int inputN1 = int.Parse(Console.ReadLine());
Console.WriteLine(GetNumbersString(inputN1));
Console.WriteLine();
*/
/*
 Task 2:
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
 */
Console.WriteLine("Task 2 Sum of natural numbers in the range from M to N:");
void ShowSumRange (int M, int N)
{
    Console.Write($"M = {M}; N = {N} -> ");
    if (M < N)
    {
        Console.WriteLine(GetSumRange(M, N));
    }
    else
    {
        Console.WriteLine(GetSumRange(N, M));
    }
}
int GetSumRange (int start, int end)
{
    if (start == end) return end;
    return start + GetSumRange(start + 1, end);
}
Console.Write("Enter M: ");
int inputM1 = int.Parse(Console.ReadLine());
Console.Write("Enter N: ");
int inputN2 = int.Parse(Console.ReadLine());
ShowSumRange(inputM1, inputN2);
