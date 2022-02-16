// Найти максимальное из трёх чисел.
int a = 1;
int b = 2;
int c = 3;
int max = 0;
if (a > b)
{
    max = a;
} 
if (a < b)
{
    max = b;
}
if (a < c)
{
    max = c;
}
Console.WriteLine("Максимальное число: " + max);