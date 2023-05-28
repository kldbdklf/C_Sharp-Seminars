/*
Task 1: 
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

using System.Transactions;

Console.WriteLine("Task 1 the palindrom: ");
bool work = true;
int inputNumber1 = 0;
while (work)
{
    Console.Write("Enter your five-digit number: ");
    inputNumber1 = int.Parse(Console.ReadLine());
    if ((inputNumber1/100000) == 0 && (inputNumber1 / 10000 > 0)) { work = false; }
    else {
        Console.WriteLine("Your number isn't five-digit. Repeat the input.");
        work = true; 
    }
}
if (inputNumber1/10000 == inputNumber1%10)
{
    if ((inputNumber1 / 1000 % 10) == (inputNumber1 % 100 / 10))
    {
        Console.WriteLine("Your number is palindrom!");
    }
    else Console.WriteLine("Your number isn't palindrom!");
}
else Console.WriteLine("Your number isn't palindrom!");


/*
 * Task 2: 
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/



