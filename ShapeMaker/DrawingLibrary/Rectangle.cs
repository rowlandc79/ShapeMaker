using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DrawingLibrary
{
    public class Rectangle : Widget
    {
        private int _width { get; set; }
        private int _height { get; set; }



        /// <summary>
        /// Very basic initial widget object...which will be refactored
        /// </summary>
        public Rectangle(int x, int y, int width, int height)
        {
            base._location = new Location(x, y);
            _width = width;
            _height = height;
        }

        public override string Print()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Rectangle");
            sb.Append(" (");
            sb.Append(_location.X.ToString());
            sb.Append(",");
            sb.Append(_location.Y.ToString());
            sb.Append(") width=");
            sb.Append(_width.ToString());
            sb.Append(" height=");
            sb.Append(_height.ToString());

            return sb.ToString();
        }


    }
}
