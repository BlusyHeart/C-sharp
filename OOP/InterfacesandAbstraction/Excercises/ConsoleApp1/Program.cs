using System;
using System.Collections.Generic;
using System.Linq;

namespace Shapes
{
    class Program
    {
        static void Main()
        {
            List<IDrawable> shapes = new List<IDrawable>();

            shapes.Add(new Circle(7));       
            shapes.Add(new Rectangle(5,5));
            shapes.Add(new Square(9));
            shapes.Add(new Circle(9));

            foreach (IDrawable shape in shapes)
            {
                shape.DrawShape();
                Console.WriteLine();
            }
        }
    }
}
