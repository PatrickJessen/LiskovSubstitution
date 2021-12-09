using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    /// <summary>
    /// Represents a Pattern of X and Y positions
    /// </summary>
    public class Pattern
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public Pattern(int x, int y)
        {
            PositionX = x;
            PositionY = y;
        }
    }
}
