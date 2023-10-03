using System;

namespace Lesson_11_Interfaces
{
    class Line : IFigure, IStyle
    {
        int x1;
        int y1;
        int x2;
        int y2;
        ConsoleColor color;
        uint thickness;

        public int X { get => x1; set => x1 = value; }
        public int Y { get => y1; set => y1 = value; }
        public int X2 { get => x2; set => x2 = value; }
        public int Y2 { get => y2; set => y2 = value; }

        public ConsoleColor Color { get => color; set => color = value; }
        public uint Thickness { get => thickness; set => thickness = value; }
        public string Title { get; set; }

        public void draw()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(20, 20);
            Console.WriteLine("рисование линии с координатами (Х, У) - (X2, Y2), цветом color и толщиной линии thickness");
            Console.SetCursorPosition(X, Y);
            Console.Write("Line");
            Console.ResetColor();

            // здесь должно быть реальное рисование линии по алгоритму Брезенхейма
        }
    }
}
