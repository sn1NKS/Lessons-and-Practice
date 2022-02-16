// Найти расстояние между точками в пространстве 2D/3D.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
 
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double x1=0;
            Double x2=0;
            Double y1=0;
            Double y2=0;
            Double rasst;
            Console.Write("x1=");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2=");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1=");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2=");
            y2 = Convert.ToDouble(Console.ReadLine());
           
            {
                rasst = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
                Console.WriteLine("rasst:" + rasst);
                Console.ReadLine();
            }
        }
    }
}