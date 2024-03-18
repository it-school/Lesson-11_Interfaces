using System;

namespace Lesson_11_Interfaces
{
    class Point : IFigure, IStyle
    {
        int _x;
        int _y;
        ConsoleColor _color;
        uint _thickness;

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }
        public ConsoleColor Color { get => _color; set => _color = value; }
        public uint Thickness { get => _thickness; set => _thickness = value; }
        public string Title { get; set; }

        public void DefaultMethod()
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            Console.ForegroundColor = _color;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"рисование точки с координатами ({X}, {Y}), цветом color и толщиной линии thickness");
            Console.SetCursorPosition(X, Y);
            Console.Write("*");
            Console.ResetColor();
        }
    }
}
