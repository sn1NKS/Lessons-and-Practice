Console.WriteLine("Введите число от 10 до 99: ");
int a = int.Parse(Console.ReadLine());
int num1 = a % 10;
int num2 = a / 10;
if(num1 > num2)
{
    Console.WriteLine("Большее число: " + num1);
}
else Console.WriteLine("Большее число: " + num2);