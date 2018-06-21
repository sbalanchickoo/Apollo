using System;

namespace Apollo.CSInterfaces.Module1.Interface.CS.Interfaces
{
    public class OctagonInterface : Object, IPolygonInterface
    {

        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }
        
        public OctagonInterface(int sideLength)
        {
            SideLength = sideLength;
            NumberOfSides = 8;
        }

        public int GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        public double GetArea()
        {
            return SideLength * SideLength * (2 + 2 * Math.Sqrt(2));
        }
    }
}
