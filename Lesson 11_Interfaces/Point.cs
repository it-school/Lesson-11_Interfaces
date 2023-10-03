using System;

namespace Lesson_11_Interfaces
{
    class Point : IFigure, IStyle
    {
        int x;
        int y;
        ConsoleColor color;
        uint thickness;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public ConsoleColor Color { get => color; set => color = value; }
        public uint Thickness { get => thickness; set => thickness = value; }
        public string Title { get; set; }

        public void draw()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("рисование точки с координатами (Х, У), цветом color и толщиной линии thickness");
            Console.SetCursorPosition(X, Y);
            Console.Write("*");
            Console.ResetColor();
        }
    }
}
