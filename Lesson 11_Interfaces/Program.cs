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
            Line line = new Line();

            point.draw();
            line.draw();
            
        }
    }
}
