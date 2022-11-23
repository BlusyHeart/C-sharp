using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle : IDrawable
    {
        public Circle(int radius)
        {
            Radius = radius;
        }

        public int Radius { get; private set; }

        public void Draw()
        {
            for (int i = 0; i < Radius * 2; i++)
            {
                for (int j = 0; j < Radius * 2; j++)
                {
                    var distance = Math.Sqrt((Radius - i) 
                        * (Radius - i) + (Radius - j) * (Radius - j));

                    if (distance <= Radius)
                    {
                        Console.Write("**");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                   
                }
                Console.WriteLine();
            }
        }

        public void DrawShape()
        {
            for (int i = 0; i < Radius * 2; i++)
            {
                for (int j = 0; j < Radius * 2; j++)
                {
                    var distance = Math.Sqrt((Radius - i)
                        * (Radius - i) + (Radius - j) * (Radius - j));

                    if (Math.Ceiling(distance) == Radius)
                    {
                        Console.Write("**");
                    }
                    else
                    {
                        Console.Write("  ");
                    }

                }
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            return $"Circle with radius {Radius}";
        }
    }
}
