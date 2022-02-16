// Программа проверяет пятизначное число на палиндромом.
int a = 515; //new Random().Next(10000, 99999);
Console.WriteLine(a);

if (a / 10000 == a % 10 && a / 1000 % 10 == a % 100 / 10) 
{
    Console.WriteLine("Число палиндром");
}
else Console.WriteLine("Число не палиндром или не пятизначное");
