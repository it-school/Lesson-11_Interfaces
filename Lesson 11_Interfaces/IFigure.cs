using System;

namespace Lesson_11_Interfaces
{
    interface IFigure
    {
        int X { get; set; }
        int Y { get; set; }
        string Title { get; set; }

        void draw();

        void DefaultMethod()
        {
            Console.WriteLine("This is default method implementation in interface");
        }
    }
}
