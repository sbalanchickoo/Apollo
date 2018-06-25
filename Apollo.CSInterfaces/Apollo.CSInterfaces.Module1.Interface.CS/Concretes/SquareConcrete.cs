using System;
using System.Collections.Generic;
using System.Text;

namespace Apollo.CSInterfaces.Module1.Interface.CS.Concretes
{
    public class SquareConcrete : PolygonConcrete
    {
        public override double GetArea()
        {
            return SideLength * SideLength;
        }

        public SquareConcrete (int sideLength) : base(4, sideLength)
        {
            
        }
    }
}
