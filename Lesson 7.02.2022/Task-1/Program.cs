// По двум заданным числам проверять является ли одно квадратом другого

int a = new Random().Next(1, 99);
Console.WriteLine(a);
int b = new Random().Next(1, 99);
Console.WriteLine(b);

if (a == b*b || b == a*a)
{
    Console.WriteLine("Одино число является квадратом второго");
}
else Console.WriteLine("Нет квадратов");

