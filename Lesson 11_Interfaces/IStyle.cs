using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_Interfaces
{
    interface IStyle
    {
        ConsoleColor Color { get; set; }
        uint Thickness { get; set; }

        void draw();
    }
}
