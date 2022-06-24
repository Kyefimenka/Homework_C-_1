// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Enter number ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(number);
if (number % 2 == 0)
{
    Console.WriteLine(" is even number");
}
else
{
    Console.WriteLine(" is odd number");
}