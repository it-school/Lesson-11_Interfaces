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
            Point point = new Point(10, 4, ConsoleColor.Cyan, 1, "P1");
            Line line = new Line();

            point.draw();
            line.draw();            
        }
    }
}
