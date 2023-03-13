// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Enter first number: ");
int N1= int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter second number: ");
int N2= int.Parse(Console.ReadLine()!);

if (N1 > N2)
{
    Console.WriteLine ($"{N1} is Max, {N2} is Min");
}    
else 
{   
    Console.WriteLine ($"{N2} is Max, {N1} is Min");
}

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
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Enter number: "); 
int number = int.Parse(Console.ReadLine()!); 
 
int N = 2;  
    while(N <= number) 
    { 
        Console.Write(N + " "); 
        N = N + 2; 
    } 
