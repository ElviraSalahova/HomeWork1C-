// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Enter first number: ");
int N1= int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter second number: ");
int N2= int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter second number: ");
int N3= int.Parse(Console.ReadLine()!);

int max=N1;
if (N2>max)max=N2;
if (N3>max)max=N3;

Console.WriteLine ($"Max is {max}");
