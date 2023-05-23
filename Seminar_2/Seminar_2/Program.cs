/* Task 1 
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
/* 
 * Console.WriteLine("Task 1 second figure of number: ");
Console.Write("Enter your three-digit number: ");
int inputNumber = int.Parse(Console.ReadLine());
Console.WriteLine("The second figure : " + (inputNumber / 10) % 10);
*/ 
/* Task 2 :
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Task 2 third digit in number: ");
Console.Write("Enter your number: ");
int inputNumber2 = int.Parse(Console.ReadLine());
if ((inputNumber2 / 10) < 10) Console.WriteLine("There is no third digit!");
else
{
    int N = 1, counter = 2;
    while (N != 0)
    {
        counter++;
        N = inputNumber2 / Convert.ToInt32(Math.Pow(10, counter));
    } 
    Console.WriteLine("Third digit in your number is " + (inputNumber2 / Convert.ToInt32(Math.Pow(10, (counter - 3))) % 10));
};

