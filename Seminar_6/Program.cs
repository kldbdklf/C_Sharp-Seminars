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
int[] CreateArrayAfterMultiplication(int[] array) // Функция, принимающая существующий массив чисел и возвращающая новый массив, состоящий из результатов парного умножения чисел из первоначального массива
{
    int[] result;
    if (array.Length % 2 == 0) {  // проверка на четность длины массива
       result = new int[array.Length / 2]; // если длина четная, то длина нового массива определяется делением на 2
    }
    else
    {
       result = new int[array.Length / 2 + 1]; // если длина нечетная, то в новый массив будет включено число без пары, место для которого освобождается добавлением (+ 1)
        result[array.Length / 2] = array[array.Length / 2]; // присвоение последнему элементу нового массива числа без пары
    }
    for (int i = 0, j = array.Length - 1; i < j;i++, j--) { // перемножение пар чисел
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

/*
 Task 2: 
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
 */

Console.WriteLine("Task 2 User's numbers more than zero: ");
List<double> CreateArrayByUser () // функция по созданию списка (list) из чисел пользователя
{
    string input; // ввод пользователя
    bool work = true, inputCorrect = true; // work - проверка на желание продолжать ввод чисел со стороны пользователя. inputCorrect - корректность введенного пользователем значения на соответствие числу типа double или команде Enough 
    double buffer = 0;
    List<double> result = new List<double>();
    Console.WriteLine("Let's create your array. " +
        "The numbers must be entered after the label \"Number:\" appears on the screen.\n" +
        "The end of entering each number must be accompanied by pressing the Enter button.\n " +
        "In order to stop entering numbers, write the command Enough and press the Enter button.");
    while (work) // бесконечный цикл, окончание которого возможно только при вводе команды Enough вместо числа
    {
        Console.Write("Number: ");
        input = Console.ReadLine();
        inputCorrect = double.TryParse(input, out buffer); // проверка на корректность введенного пользователем значения на соответствие числу типа double 
        if (inputCorrect)
        {
            result.Add(buffer); // добавление корректного числа
        }
        else if (input == "Enough") 
        {
            work = false; // окончание работы программы при введенной команде Enough
            return result;
        }
        else
        {
            Console.WriteLine("Incorrect input. Please, enter only numbers.");
        }
    }
    return result;
    }
int CheckNumbersMoreThanZero (List<double> list) // функция для поиска чисел больше 0
{
    int result = 0;
    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] > 0) { result++; }
    }
    return (result);
}
void ShowNumbersMoreThanZero (List<double> list) // функция для показа числе больше 0
{
    if (list.Count == 0)
    {
        Console.WriteLine("Your array is empty."); // если пользователь не ввел ни одного числа, то будет отображено соответствующее сообщение
    }
    else
    {
        Console.Write($"Amount of numbers more than 0 : {CheckNumbersMoreThanZero(list)} \n");
    }
}
List<double> list1 = CreateArrayByUser();
ShowNumbersMoreThanZero(list1);

/*
Task 3:
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.WriteLine("Task 3 Cross point: ");
Console.Write("Enter b1 : ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Enter k1 : ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Enter b2 : ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Enter k2 : ");
double k2 = double.Parse(Console.ReadLine());
double x = 0, y = 0;
if (k1 != k2) {
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"Cross point = ({x}; {y})");
}
else Console.WriteLine("Exception: Division by 0. K1 cann't be equal K2.");








