/*
 Task 1: 
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
 */
using System.Transactions;

Console.WriteLine("Task 1 multiplication: ");
void FillArray(int[] array) // функция, заполняющая массив случайными числами от -100 до 100
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-100, 101);
    }
}
void ShowArray(int[] array) // функция, выводящая массив на консоль
{
    Console.WriteLine($"Array : [{String.Join(" | ", array)}]");
}
int[] CreateArrayAfterMultiplication(int[] array)
{
    int[] result;
    if (array.Length % 2 == 0) { 
       result = new int[array.Length / 2]; 
    }
    else
    {
       result = new int[array.Length / 2 + 1];
        result[array.Length / 2] = array[array.Length / 2];
    }
    for (int i = 0, j = array.Length - 1; i < j;i++, j--) {
        result[i] = array[i] * array[j];
    }
    return result;
}
Console.Write("Enter length of array:");
int length = int.Parse(Console.ReadLine());
int[] array1 = new int[length];
FillArray(array1);
ShowArray(array1);
int[] array2 = CreateArrayAfterMultiplication(array1);
ShowArray(array2);