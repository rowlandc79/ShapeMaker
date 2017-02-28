using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DrawingLibrary
{


    public  class Widget //not abstract JUST yet...
    {
        private Location _location {get;set;}
        private string _type { get; set; } //this is VERY temporary...will replace with ptoper inheritance shortly
        private int _width { get; set; }
        private int _height { get; set; }

        public Location Location {
            get
            {
                return _location;
            }
        }


        /// <summary>
        /// Very basic initial widget object...which will be refactored
        /// </summary>
        public Widget(string type,int x, int y, int width, int height)
        {
            _type = type;
            _location = new Location(x, y);
            _width = width;
            _height = height;
        }

        public string Print()
        {
            StringBuilder sb = new StringBuilder();
            TextInfo titleCaser = new CultureInfo("en-GB", false).TextInfo;

            sb.Append(titleCaser.ToTitleCase(_type));
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
