/*
Task 1: 
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
/*
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
*/

/*
 * Task 2: 
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*
Console.WriteLine("Task 2 The distance between points in 3D space: ");
Console.Write("Enter X1: ");
double X1 = double.Parse(Console.ReadLine());
Console.Write("Enter Y1: ");
double Y1 = double.Parse(Console.ReadLine());
Console.Write("Enter Z1: ");
double Z1 = double.Parse(Console.ReadLine());
Console.Write("Enter X2: ");
double X2 = double.Parse(Console.ReadLine());
Console.Write("Enter Y2: ");
double Y2 = double.Parse(Console.ReadLine());
Console.Write("Enter Z2: ");
double Z2 = double.Parse(Console.ReadLine());
double d = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
Console.Write($"The distance between points = {Math.Round(d, 2)}");
*/


/*
 Task 3:
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Task 3 The table of cubes of numbers: "); // Допустил, что при отрицательном числе кубы нужно представлять от -1 до N, а не от 1 до N
void showTable (int number)
{
    int numberSign = 1;
    if (number < 0) { numberSign = -1;
        number *= -1;
        Console.Write(Math.Pow(1, 3) + "\t" + Math.Pow(0, 3) + "\t");
    }
    for (int i = 1; i <= number; i++)
    {
        Console.Write((Math.Pow(i, 3) * numberSign) + "\t");
}
}
Console.Write("Enter your integer: ");
int inputNumber2 = int.Parse(Console.ReadLine());
showTable(inputNumber2);



