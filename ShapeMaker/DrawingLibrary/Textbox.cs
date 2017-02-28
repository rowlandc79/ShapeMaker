using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DrawingLibrary
{
    public class Textbox : Widget
    {
        private int _width { get; set; }
        private int _height { get; set; }

        private string _text { get; set; }



        /// <summary>
        /// Very basic initial widget object...which will be refactored
        /// </summary>
        public Textbox(int x, int y, int width, int height, string text)
        {
            base._location = new Location(x, y);
            _width = width;
            _height = height;
            _text = text;
        }

        public override string Print()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Textbox");
            sb.Append(" (");
            sb.Append(_location.X.ToString());
            sb.Append(",");
            sb.Append(_location.Y.ToString());
            sb.Append(") width=");
            sb.Append(_width.ToString());
            sb.Append(" height=");
            sb.Append(_height.ToString());
            sb.Append(" Text=\"");
            sb.Append(_text);
            sb.Append("\"");

            return sb.ToString();
        }


    }
}
