using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingLibrary
{
    public class Location
    {
        private int _x { get; set; }
        private int _y { get; set; }

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public Location(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

    }
}
