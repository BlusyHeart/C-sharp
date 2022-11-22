namespace ClassBoxData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());

            double height = double.Parse(Console.ReadLine());

            double length = double.Parse(Console.ReadLine());

            Box box = new Box(length, width, height);

            Console.WriteLine(box.SurfaceArea());
            Console.WriteLine(box.LateralSurfaceArea());
            Console.WriteLine(box.Volume());
        }
    }
}

