using System;
using System.Collections.Generic;
using System.Text;

namespace Apollo.CSInterfaces.Module1.Interface.CS.Interfaces
{
    public interface IPolygonInterface
    {

        int NumberOfSides { get; set; }
        int SideLength { get; set; }

        int GetPerimeter();

        double GetArea();


    }
}
