using System;

namespace Lesson_11_Interfaces
{
    interface IFigure
    {
        int X { get; set; }
        int Y { get; set; }
        string Title { get; set; }

        void Draw();

        void DefaultMethod();
/*
//      Default implementation is available from C#8
        void DefaultMethod()
        {
            Console.WriteLine("This is default method implementation in interface");
        }
*/
    }
}
