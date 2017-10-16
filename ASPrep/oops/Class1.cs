using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oops
{
    public class Class1
    {
    }
    public class Aperture
    {
        protected double height = 5;
        protected double width = 10;

        protected double thickness = 15;
        public double get_volume()
        {
            double volume = height * width * thickness;
            if (volume < 0)
                return 0;
            return volume;
        }
    }
}

