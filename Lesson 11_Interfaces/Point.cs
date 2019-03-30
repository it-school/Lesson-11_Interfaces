using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_Interfaces
{
    class Point : IFigure, IStyle
    {
        private int x;
        private int y;
        private string pointName;
        ConsoleColor color;
        uint thickness;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public ConsoleColor Color { get => color; set => color = value; }
        public uint Thickness { get => thickness; set => thickness = value; }
        public string Title { get => pointName; set => pointName = value; }

        public void draw()
        {
            // Здесь должно быть рисование точки с координатами (Х, У),
            // цветом color и толщиной линии thickness
            Console.ForegroundColor = this.Color;
            Console.SetCursorPosition(X, Y);
            Console.WriteLine("*");
            Console.ResetColor();
        }

        public Point()
        {
        }

        public Point(int x, int y, ConsoleColor color, uint thickness, string title)
        {
            X = x;
            Y = y;
            Color = color;
            Thickness = thickness;
            Title = title;
        }
    }
}
