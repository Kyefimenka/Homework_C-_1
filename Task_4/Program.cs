// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Enter number ");
int N = Convert.ToInt32(Console.ReadLine());
int curent = 2;
while (curent <= N)
{ 
    Console.WriteLine(curent);
    curent += 2;
}
