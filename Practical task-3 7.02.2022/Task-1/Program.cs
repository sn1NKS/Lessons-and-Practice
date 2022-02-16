// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y.
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
            Random d = new Random();
            Point cur = new Point(d.Next(-100, 100), d.Next(-100, 100));
            Console.WriteLine("{0}, {1}", cur.X, cur.Y);
            if (cur.X < 0 && cur.Y > 0)
                Console.WriteLine("Точка находится во 2й координатной четверти");
            else
                Console.WriteLine("Точка находится не во 2й координатной четверти");
            Console.Read();
        }
    }
}