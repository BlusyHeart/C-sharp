using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Square : IDrawable
    {
        public Square(int side)
        {
            Side = side;           
        }     
        public int Side { get; set; }

        public void Draw()
        {
            for (int i = 0; i < Side - 3; i++)
            {
                Console.WriteLine(new string('*', Side * 2));
            }
        }

        public void DrawShape()
        {
            Console.WriteLine(new string('*', Side * 2));
            for (int i = 0; i < Side - 2; i++)
            {
                Console.WriteLine("*" + new string(' ', Side * 2 - 2) + "*");
            }
            Console.WriteLine(new string('*', Side * 2));
        }

        public override string ToString()
        {
            return $"Square side is {Side}";
        }
    }
}
