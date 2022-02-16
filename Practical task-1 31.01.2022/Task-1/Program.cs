// Даны два числа. Показать большее и меньшее число.
int a = 100;
int b = 50;
int max = 0;
int min = 0;
if (a > b)
{
    max = a;
    min = b;
    Console.WriteLine("Большее число: " + max);
    Console.WriteLine("Меньшее число: " + min);
}
else if (a < b)
{
    max = b;
    min = a;
    Console.WriteLine("Большее число: " + max);
    Console.WriteLine("Меньшее число: " + min);
}
else if (a == b)
{
    max = b;
    min = a;
    Console.WriteLine("Числа равны: " + max);
    Console.WriteLine("Числа равны: " + min);
}