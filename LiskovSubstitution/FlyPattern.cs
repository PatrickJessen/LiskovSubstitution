using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    /// <summary>
    /// Represents a Pattern of X, Y and Z positions for flying objects
    /// </summary>
    public class FlyPattern : Pattern
    {
        public int PositionZ { get; set; }
        public FlyPattern(int x, int y, int z) : base(x, y)
        {
            PositionZ = z;
        }
    }
}
