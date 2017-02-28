using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingLibrary.Utils
{
    /// <summary>
    /// Creates a drawing object that can contain multiple widgets and print them to the screen.
    /// </summary>
    public class Drawing
    {
        private List<Widget> _widgets { get; set; }


        public Drawing()
        {
            _widgets = new List<Widget>(); 
        }

        public void AddWidget(Widget widget)
        {
            this._widgets.Add(widget);
        }

        public void Print()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Current Drawing");
            Console.WriteLine("---------------------");
            foreach (var widget in _widgets)
            {
                Console.WriteLine(widget.Print());
            }
            Console.WriteLine("");
            Console.WriteLine("Press any key to end");
            Console.ReadKey();
        }

    }
}
