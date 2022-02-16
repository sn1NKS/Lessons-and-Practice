// Дано число. Проверить кратно ли оно 7 и 23
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
if (a % 7 == 0 && a % 23 == 0 ){
    Console.WriteLine("Число кратно указанным числам"); 
}
else Console.WriteLine("Число не кратно указанным числам");
