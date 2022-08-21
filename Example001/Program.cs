// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int x, y, max, min;
Console.WriteLine("Введите первое число");
x = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите второе число");
y = Convert.ToInt32 (Console.ReadLine());
max = 0;
min = 0;
if (x>y)
{
    max = x;
    min = y;
}
else
{
    min = x;
    max = y;
}
Console.WriteLine("Большее число "+ (max ));
Console.WriteLine("Меньшее число "+ (min ));