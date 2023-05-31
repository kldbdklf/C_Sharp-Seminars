/*
Task 1: 
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4-> 16
*/


// Решил комментить все подряд, чтоб привыкнуть
/*
Console.WriteLine("Task 1 Exponentiation: ");
void fillArray (double[] array) { // функция заполнения массива
    Console.WriteLine($"Let's fill array of {array.Length} numbers: "); // Надпись чтобы пользователь знал сколько символов потребуется ввести
    for (int i = 0; i < array.Length; i++) 
    {
        Console.Write($"Enter your number with index {i}: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
}
void showArray(double[] array) // функция для демонстрации массива
{
    Console.WriteLine($"Array : [{String.Join("|", array)}]"); // Использовал новый метод демонстрации массива
}
void exponentiationOfArray(double[] array, double degree) { // функция для возведения всех элементов массива в степень
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = Math.Pow(array[i], degree);
    }
}
int length = 5;
double[] arrayOfNumbers = new double[length]; // сделал массив, чтоб хоть какой-то смысл в цикле был, а то цикл, состоящий из одного возведения в степень выглядел странно
fillArray(arrayOfNumbers);
Console.Write("Enter your degree: "); // массив степеней решил не создавать, а возвести все числа в одну степень. Да и если возводить каждое число в свою степень, то массивы вообще не нужны
double inputDegree = Convert.ToDouble(Console.ReadLine()); // принимает в том числе десятичную дробь в качестве степени
Console.WriteLine("Array before exponentiation: ");
showArray(arrayOfNumbers);
exponentiationOfArray(arrayOfNumbers, inputDegree);
Console.WriteLine("Array after exponentiation: ");
showArray(arrayOfNumbers);
*/

/*
Task 2: 
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Task 2 The sum of number's digits: ");
void showSumOfDigits(int number) // функция для расчета суммы цифр 
{
    int sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    Console.WriteLine($"The sum of number's digits is {Math.Abs(sum)}");
}
Console.Write("Enter your number: ");
int inputNumber1 = Convert.ToInt32(Console.ReadLine());
showSumOfDigits(inputNumber1);
