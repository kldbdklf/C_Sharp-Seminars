/* Task 1 
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Task 1: ");
Console.Write("Enter your three-digit number: ");
int inputNumber = int.Parse(Console.ReadLine());
Console.WriteLine("The second figure : " + (inputNumber / 10) % 10);
