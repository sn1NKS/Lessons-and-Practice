// Задать номер четверти, показать диапазоны для возможных координат.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
 
            Console.WriteLine("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());
 
            if ((x > 0) && (y > 0))
                Console.WriteLine("I четверть");
            else
            {
                if ((x < 0) && (y > 0))
                    Console.WriteLine("II четверть");
                else
                {
                    if ((x < 0) && (y < 0))
                        Console.WriteLine("III четверть");
                    else
                    {
                        if ((x > 0) && (y < 0))
                            Console.WriteLine("IV четверть");
                        else
                            Console.WriteLine("Точка лежит на оси");
                    }
                    Console.ReadKey();
                }
            }
        }
    }
}