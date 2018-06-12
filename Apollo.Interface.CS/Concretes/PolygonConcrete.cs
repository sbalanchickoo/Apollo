using System;
using System.Collections.Generic;
using System.Text;

namespace Apollo.Interface.CS.Concretes
{
    public class PolygonConcrete
    {
        public int NumberOfSides;
        public int SideLength;

        public int GetPerimeter()
        {
            int perimeter = NumberOfSides * SideLength;
            return perimeter;
        }

        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }
        
    }
}
