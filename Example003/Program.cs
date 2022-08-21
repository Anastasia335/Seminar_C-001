// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
int x;
Console.WriteLine("Введите число");
x = Convert.ToInt32 (Console.ReadLine());
int y= x%2;
if (y == 0)
{
 Console.WriteLine("Введенное число четное");  
}
else
{
    Console.WriteLine("Введенное число не четное");
}
