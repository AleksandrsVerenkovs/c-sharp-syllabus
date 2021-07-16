using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double areaOfCircle(decimal radius)
        {
            return Math.Round(Math.PI * (double)radius * 2,2);
        }

        public static double areaOfRectangle(decimal length, decimal width)
        {
            return Math.Round((double)(length*width),2);
        }

        public static double areaOfTriangle(decimal ground, decimal h)
        {
            return Math.Round((double)(ground * h) * 0.5,2);
            
        }
    }
}
