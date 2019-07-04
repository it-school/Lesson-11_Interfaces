using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.Color = ConsoleColor.Blue;
            point.X = 5;
            point.Y = 8;
            point.draw();

            Console.ReadLine();


            Line line = new Line();
            line.Color = ConsoleColor.Red;
            line.X = 10;
            line.Y = 20;
            line.X2 = 10;
            line.Y2 = 20;
            line.draw();

            Console.WriteLine();
        }
    }
}
