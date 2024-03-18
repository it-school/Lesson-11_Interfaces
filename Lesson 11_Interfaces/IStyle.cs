using System;

namespace Lesson_11_Interfaces
{
    interface IStyle
    {
        ConsoleColor Color { get; set; }
        uint Thickness { get; set; }

        void Draw();
    }
}
