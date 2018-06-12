using System;
using System.Collections.Generic;
using System.Text;

namespace Apollo.Interface.CS.Abstracts
{
    public class TriangleAbstract : PolygonAbstract
    {
        public override double GetArea()
        {
            return SideLength * SideLength;
        }

        public TriangleAbstract(int sideLength) : base(3, sideLength)
        {

        }
    }
}
