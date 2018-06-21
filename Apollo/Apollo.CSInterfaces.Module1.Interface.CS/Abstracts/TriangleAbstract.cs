using System;
using System.Collections.Generic;
using System.Text;

namespace Apollo.CSInterfaces.Module1.Interface.CS.Abstracts
{
    public class TriangleAbstract : PolygonAbstract
    {
        public override double GetArea()
        {
            return (double)SideLength * SideLength * Math.Sqrt(3) / 4;
        }

        public TriangleAbstract(int sideLength) : base(3, sideLength)
        {

        }


    }
}
