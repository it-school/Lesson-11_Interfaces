using System;

namespace Lesson_11_Interfaces
{
    class Program
    {
        static void Main()
        {
            Point point = new Point
            {
                Color = ConsoleColor.Blue,
                X = 5,
                Y = 8
            };
            point.Draw();

            Console.ReadLine();

            Line line = new Line
            {
                Color = ConsoleColor.Red,
                X = 10,
                Y = 20,
                X2 = 30,
                Y2 = 25
            };
            line.Draw();

            Console.WriteLine();
        }
    }
}
