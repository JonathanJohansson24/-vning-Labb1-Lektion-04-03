using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_Labb1_Lektion_04_03
{
    internal class Box:IEquatable<Box>
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public double Length { get; set; }
        public double Volume { get; private set; }

        public Box(double height, double width, double length)
        {
            Height = height;
            Width = width;
            Length = length;
            Volume = CalculateVolume();
        }
        private double CalculateVolume()
        {
            return Height * Width * Length;
        }
        public bool Equals(Box? other)
        {
            if (new BoxSameProp().Equals(this, other))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
