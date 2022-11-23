using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle : IDrawable
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; private set; }

        public int Height { get; private set; }

        public void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                Console.WriteLine(new string('*', Width * 2));
            }
        }

        public void DrawShape()
        {
            Console.WriteLine(new string('*', Width * 3));
            for (int i = 0; i < Height - 2; i++)
            {
                Console.WriteLine("*" + new string(' ', Width * 3 - 2) + "*");
            }
            Console.WriteLine(new string('*', Width * 3));
        }

        public override string ToString()
        {
            return $"Rectangle with width {Width} and height {Height}";
        }
    }
}
