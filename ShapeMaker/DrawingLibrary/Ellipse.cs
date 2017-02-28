using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DrawingLibrary
{
    public class Ellipse : Widget
    {
        private int _hDiameter { get; set; }
        private int _vDiameter { get; set; }



        public Ellipse(int x, int y, int h, int v)
        {
            base._location = new Location(x, y);
            _hDiameter = h;
            _vDiameter = v;
        }

        public override string Print()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Ellipse");
            sb.Append(" (");
            sb.Append(_location.X.ToString());
            sb.Append(",");
            sb.Append(_location.Y.ToString());
            sb.Append(") diameterH=");
            sb.Append(_hDiameter.ToString());
            sb.Append(" diameterV=");
            sb.Append(_vDiameter.ToString());

            return sb.ToString();
        }


    }
}
