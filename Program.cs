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
