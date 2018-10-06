using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void draw()
        {
// Здесь должно быть рисование линии с координатами (Х, У) - (X2, Y2),
// цветом color и толщиной линии thickness
        }
    }
}
