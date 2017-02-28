using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrawingLibrary;

namespace ShapeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawingLibrary.Utils.Drawing drawing = new DrawingLibrary.Utils.Drawing();

            drawing.AddWidget(new Rectangle(10, 10, 30, 40));
            drawing.AddWidget(new Square(15, 30, 35));
            drawing.AddWidget(new Ellipse(100, 150, 300, 200));
            drawing.AddWidget(new Circle(1, 1, 300));
            drawing.AddWidget(new Textbox(5, 5, 200, 100, "sample text"));

            drawing.Print();
        }
    }
}
