/*
 Task 1:
 Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
 */
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Task 1 Natural numbers in the range from N to 1:");
string ShowNaturalNumbers (int N)
{
    string result = String.Empty;
    if (N == 1) return N.ToString();
    return N + ", " + ShowNaturalNumbers(N - 1);
}
Console.Write("Enter N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine(ShowNaturalNumbers(N));