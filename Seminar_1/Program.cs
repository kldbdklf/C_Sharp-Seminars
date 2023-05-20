// Сделал все четыре кода работающими одновременно

/*Task 1 
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 
*/


/*Console.WriteLine("Task 1 : Max and min of two numbers.");
Console.WriteLine("Enter numbers: ");
Console.Write("Number 1 = ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Number 2 = ");
double number2 = Convert.ToDouble(Console.ReadLine());
if (number1 == number2)
{
    Console.WriteLine("The numbers are equal.");
}
else if (number1 > number2)
{
    Console.WriteLine("Number " + number1 + " is max. Number " + number2 + " is min.");
}
else
{
    Console.WriteLine("Number " + number2 + " is max. Number " + number1 + " is min.");
}
*/

/* Task 2
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 
*/

/*
Console.WriteLine("Task 2 : Max of numbers.");
Console.Write("Enter amount of numbers: ");
int amountOfNumbers = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[amountOfNumbers];
Console.WriteLine("Enter numbers: ");
for (int i = 0; i < amountOfNumbers; i++)
{
    Console.Write("Number " + (i + 1) + " : ");
    numbers[i] = Convert.ToDouble(Console.ReadLine());
}
double max = numbers[0];
for (int i = 0; i < amountOfNumbers; i++)
{
    if (max < numbers[i])
    {
        max = numbers[i];
    }
}
Console.WriteLine("Max of your numbers is " + max);
*/

/* Task 3
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Task 3 : An even number.");
Console.Write("Enter your number: ");
double number3 = Convert.ToDouble(Console.ReadLine());
if (number3 % 2 == 0)
{
    Console.WriteLine("Your number is even.");
}
else
{
    Console.WriteLine("Your number is uneven.");
}

