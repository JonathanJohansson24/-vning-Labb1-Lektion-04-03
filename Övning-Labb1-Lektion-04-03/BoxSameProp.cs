using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_Labb1_Lektion_04_03
{
    internal class BoxSameProp: EqualityComparer<Box>
    {
        public override bool Equals(Box? b1, Box? b2)
        {
            if (b1.Height == b2.Height && b1.Length == b2.Length && b1.Width == b2.Width || b1.Volume == b2.Volume)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode(Box box)
        {
            return box.GetHashCode();
        }
    }
}
