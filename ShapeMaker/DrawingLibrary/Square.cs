﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DrawingLibrary
{
    public class Square : Widget
    {
        private int _size { get; set; }



        /// <summary>
        /// Very basic initial widget object...which will be refactored
        /// </summary>
        public Square(int x, int y, int size)
        {
            base._location = new Location(x, y);
            _size = size;
        }

        public override string Print()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Square");
            sb.Append(" (");
            sb.Append(_location.X.ToString());
            sb.Append(",");
            sb.Append(_location.Y.ToString());
            sb.Append(") size=");
            sb.Append(_size.ToString());

            return sb.ToString();
        }


    }
}
