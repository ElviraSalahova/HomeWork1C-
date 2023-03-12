// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на 
//два без остатка(number%2==0)).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine()!);

int N= number % 2;

if(N== 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
