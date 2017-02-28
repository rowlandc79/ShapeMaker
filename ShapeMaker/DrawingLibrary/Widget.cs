using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DrawingLibrary
{

    /// <summary>
    /// Widget is an abstract class which handles shared functionality for the various shapes
    /// </summary>
    public abstract class Widget
    {
        internal Location _location {get;set;}
        

        public Location Location {
            get
            {
                return _location;
            }
        }

        


        public abstract string Print();


    }

}
