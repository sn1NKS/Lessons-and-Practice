﻿// Показать чётные числа от 1 до N.
Console.WriteLine("Введите сумму: ");
int n = int.Parse(Console.ReadLine());
    
for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);