using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBoxData
{
    internal class Box
    {
        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;

        }
        private double length;

        public double Length
        {
            get
            {
                return length;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{length} cannot be zero or negative.");
                }
                length = value;
            }
        }

        private double width;

        public double Width
        {
            get
            {
                return width;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{width} cannot be zero or negative.");
                }
                width = value;
            }
        }

        private double height;
        public double Height
        {
            get
            {
                return height;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{height} cannot be zero or negative");
                }
                height = value;
            }
        }

        public double SurfaceArea() =>
            2 * Length * Width + 
            2 * Length * Height + 2 * Width * Height;

        public double LateralSurfaceArea() => 2 * Length * (Height + Width);

        public double Volume() => Length * Height * Width;
    }
}
