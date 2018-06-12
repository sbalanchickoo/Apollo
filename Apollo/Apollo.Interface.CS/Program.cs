using System;
using Apollo.Interface.CS.Concretes;

namespace Apollo.Interface.CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SquareConcrete p1 = new SquareConcrete(5);
            Console.WriteLine(p1.GetPerimeter());
            Console.WriteLine(p1.GetArea());
            Console.ReadLine();
        }
    }
}
