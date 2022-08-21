// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int x, y, z, max;
Console.WriteLine("Введите первое число");
x = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите второе число");
y = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите третье число");
z = Convert.ToInt32 (Console.ReadLine());
max = 0;
if (x>y)
{
    max = x;
}
else
{
    max = y;
}
if (z>max)
{
    max = z;
}
else
{
    max = max;;
}
Console.WriteLine("Большее число "+ (max));
