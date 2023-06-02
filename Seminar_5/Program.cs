/*
Task 1: 
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
/*
Console.WriteLine("Task 1. Even numbers of the array: ");

void FillArrayThreeDigits(int[] array)  // функция, заполняющая массив рандомными трехзначными числами
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(100, 1000);
    }
}
*/

void ShowArray(int[] array) // функция, выводящая массив на консоль
{
    Console.WriteLine($"Array : [{String.Join(" | ", array)}]");
}
/*
void ShowEvenNumbersOfArray(int[] array) { // функция, подсчитываяющая количество четных чисел в массиве
    int counter = 0;
    for (int i = 0; i < array.Length; i++) { 
    if ((array[i] %2) == 0) { counter++; }
    }
    Console.WriteLine($"Amount of even numbers = {counter}");
}
*/
int size1 = 10;
/*
int[] array1 = new int[size1];
FillArrayThreeDigits(array1);
ShowArray(array1);
ShowEvenNumbersOfArray(array1);
*/

/*
 Task 2:
 Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*
Console.WriteLine("Task 2. Sum of numbers on odd position: ");
void FillArray (int[] array) // функция, заполняющая массив случайными числами от -100 до 100
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-100, 101);
    }
}
int SumOfNumbersOnOddPositions(int[] array) // функция, подсчитывающая сумму чисел массива на нечетных позициях
{
    int sum = 0;
    for (int i = 0;i < array.Length;i++)
    {
       if (i%2!=0) sum += array[i];
    }
    return sum;
}
int[] array2 = new int[size1]; // использую переменную размера из первой задачи
FillArray(array2);
ShowArray(array2); // функция из первой задачи
Console.WriteLine($"Sum of numbers on odd position = {SumOfNumbersOnOddPositions(array2)}");
*/


/*
Task 3:
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
 */
Console.WriteLine("Task 3. The diffrence between min and max: ");
void FillArrayDouble(double[] array) // функция, заполняющая массив случайными вещественными числами от -100 до 100
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(100 * (rand.NextDouble()*2-1), 4); // вещественное число от 0 до 1 умножается на 2 и из него вычитается 1, чтобы в подборке участвовали отрицательные числа, после этого все перемножается на 100 и округляется до 4 знака после запятой
    }
}
double FindDiffrenceBetweenMaxAndMin(double[] array) // функция, находящая разницу между минимумом и максимумом
{
    double min = array[0], max = array[0], result = 0;
    for (int i = 0;i < array.Length;i++)
    {
        if (min > array[i]) { min = array[i]; }
        if (max < array[i]) { max = array[i]; }
    }
    result = max - min;
    return result;
}
void ShowArrayDouble(double[] array) // попытался создать шаблон функции, но толи я плохо гуглил, толи в С# с этим проблемы. Выдавали только шаблоны классов, либо очень сложные конструкции
{
    Console.WriteLine($"Array : [{String.Join(" | ", array)}]");
}
double[] array3 = new double[size1];
FillArrayDouble(array3);
ShowArrayDouble(array3);
Console.WriteLine($"The diffrence between min and max = {FindDiffrenceBetweenMaxAndMin(array3)}");
