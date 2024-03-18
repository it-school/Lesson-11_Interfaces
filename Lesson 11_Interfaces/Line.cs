using System;

namespace Lesson_11_Interfaces
{
    class Line : IFigure, IStyle
    {
        int _x1;
        int _y1;
        int _x2;
        int _y2;
        ConsoleColor _color;
        uint _thickness;

        public int X { get => _x1; set => _x1 = value; }
        public int Y { get => _y1; set => _y1 = value; }
        public int X2 { get => _x2; set => _x2 = value; }
        public int Y2 { get => _y2; set => _y2 = value; }

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
            Console.SetCursorPosition(15, 20);
            Console.WriteLine($"- рисование линии с координатами ({X}, {Y}) - ({X2}, {Y2}), цветом color и толщиной линии thickness");
            Console.SetCursorPosition(X, Y);
            Console.Write("Line");
            Console.ResetColor();
            Console.SetCursorPosition(5, 25);
            // здесь должно быть реальное рисование линии по алгоритму Брезенхейма
        }
    }
}
