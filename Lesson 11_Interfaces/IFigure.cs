using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_Interfaces
{
    interface IFigure
    {
        int X { get; set; }
        int Y { get; set; }
        string Title { get; set; }

        void draw();

    }
}
