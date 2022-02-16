// Найти кубы чисел от 1 до N.
using System;
 namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 5; i++)
                Console.Write(i * i * i + " ");
            Console.ReadKey();
        }
    }
}