using System;
using System.Collections.Generic;
using System.Text;

namespace Apollo.Interface.CS.Abstracts
{
    public abstract class PolygonAbstract
    {
        public int NumberOfSides;
        public int SideLength;

        public PolygonAbstract(int numberOfSides, int sideLength)
        {
            NumberOfSides = numberOfSides;
            SideLength = sideLength;
        }

        public int GetPerimeter()
        {
            int perimeter = NumberOfSides * SideLength;
            return perimeter;
        }

        public abstract double GetArea();
    }
}
