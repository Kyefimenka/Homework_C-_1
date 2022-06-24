// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/* 2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */
Console.WriteLine("Enter first number ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number ");
int number3 = Convert.ToInt32(Console.ReadLine());
string message = "Max number = ";
bool oneMoreTwo = number1 > number2;
if (oneMoreTwo && number1 > number3)
{
    Console.Write(message);
    Console.WriteLine(number1);
}
else
{
    if (!oneMoreTwo && number2 > number3)
    {
        Console.Write(message);
        Console.WriteLine(number2);
    }
    else
    {
        Console.Write(message);
        Console.WriteLine(number3); 
    }    
}
