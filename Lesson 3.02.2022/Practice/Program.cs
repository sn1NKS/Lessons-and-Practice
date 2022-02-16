int Numer(int b)
{
  int num = b % 10;
  return b % 10;
}
Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());
int c = Numer(a);
Console.WriteLine("последняя цифра: " + с);