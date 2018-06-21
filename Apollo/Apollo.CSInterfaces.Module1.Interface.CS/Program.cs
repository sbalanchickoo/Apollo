using System;
using Apollo.CSInterfaces.Module1.Interface.CS.Concretes;
using Apollo.CSInterfaces.Module1.Interface.CS.Abstracts;
using Apollo.CSInterfaces.Module1.Interface.CS.Interfaces;

namespace Apollo.CSInterfaces.Module1.Interface.CS
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareConcrete square = new SquareConcrete(5);
            Console.WriteLine($"Square: Perimeter: {square.GetPerimeter()}");
            Console.WriteLine($"Square: Area: {Math.Round(square.GetArea(), 2)}");

            TriangleAbstract triangle = new TriangleAbstract(4);
            Console.WriteLine($"Triangle: Perimeter: {triangle.GetPerimeter()}");
            Console.WriteLine($"Triangle: Area: {Math.Round(triangle.GetArea(), 2)}");

            OctagonInterface octagon = new OctagonInterface(6);
            Console.WriteLine($"Octagon: Perimeter: {octagon.GetPerimeter()}");
            Console.WriteLine($"Octagon: Area: {Math.Round(octagon.GetArea(), 2)}");

            Console.ReadLine();
        }
    }
}
