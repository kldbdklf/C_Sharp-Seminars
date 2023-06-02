/*
Task 1: 
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.WriteLine("Task 1. Even numbers of the array: ");
void FillArray(int[] array)  // функция, заполняющая массив рандомными трехзначными числами
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(100, 1000);
    }
}
void ShowArray(int[] array) // функция, выводящая массив на консоль
{
    Console.WriteLine($"Array : [{String.Join(" | ", array)}]");
}
void ShowEvenNumbersOfArray(int[] array) { // функция, подсчитываяющая количество четных чисел в массиве
    int counter = 0;
    for (int i = 0; i < array.Length; i++) { 
    if ((array[i] %2) == 0) { counter++; }
    }
    Console.WriteLine($"Amount of even numbers = {counter}");
}
int[] array = new int[10];
FillArray(array);
ShowArray(array);
ShowEvenNumbersOfArray(array);


