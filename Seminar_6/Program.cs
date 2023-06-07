/*
 Task 1: 
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
 */
using System.Transactions;

/*
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
int[] CreateArrayAfterMultiplication(int[] array) // Функция, принимающая существующий массив чисел и возвращающая новый массив, состоящий из результатов парного умножения чисел из первоначального массива
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
*/
/*
 Task 2: 
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
 */
Console.WriteLine("Task 2 User's numbers more than zero: ");
List<double> CreateArrayByUser ()
{
    string input;
    bool work = true, inputCorrect = true;
    double buffer = 0;
    List<double> result = new List<double>();
    Console.WriteLine("Let's create your array. " +
        "The numbers must be entered after the label \"Number:\" appears on the screen.\n" +
        "The end of entering each number must be accompanied by pressing the Enter button.\n " +
        "In order to stop entering numbers, write the command Enough and press the Enter button.");
    while (work)
    {
        Console.Write("Number: ");
        input = Console.ReadLine();
        inputCorrect = double.TryParse(input, out buffer);
        if (inputCorrect)
        {
            result.Add(buffer);
        }
        else if (input == "Enough")
        {
            work = false;
            return result;
        }
        else
        {
            Console.WriteLine("Incorrect input. Please, enter only numbers.");
        }
    }
    return result;
    }
int CheckNumbersMoreThanZero (List<double> list)
{
    int result = 0;
    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] > 0) { result++; }
    }
    return (result);
}
void ShowNumbersMoreThanZero (List<double> list)
{
    if (list.Count == 0)
    {
        Console.WriteLine("Your array is empty.");
    }
    else
    {
        Console.Write($"Amount of numbers more than 0 : {CheckNumbersMoreThanZero(list)}");
    }
}
List<double> list1 = CreateArrayByUser();
ShowNumbersMoreThanZero(list1);

