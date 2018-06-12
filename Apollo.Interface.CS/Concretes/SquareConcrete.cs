using System;
using System.Collections.Generic;
using System.Text;

namespace Apollo.Interface.CS.Concretes
{
    public class SquareConcrete : PolygonConcrete
    {
        public override double GetArea()
        {
            return SideLength * SideLength;
        }

        public SquareConcrete (int side)
        {
            SideLength = side;
            NumberOfSides = 4;
        }
    }
}
