// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/* a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.WriteLine("Enter first number ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number ");
int number2 = Convert.ToInt32(Console.ReadLine());
string message = "Max number = ";
if (number1 > number2)
{
    Console.Write(message);
    Console.WriteLine(number1);
}
else
{
    Console.Write(message);
    Console.WriteLine(number2);
}
