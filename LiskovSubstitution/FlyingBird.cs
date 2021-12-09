using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public abstract class FlyingBird : Bird
    {
        public int PositionZ { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Name of the bird</param>
        /// <param name="positionX">X position of the bird</param>
        /// <param name="positionY">Y position of the bird</param>
        /// <param name="positionZ">Z position of the bird</param>
        public FlyingBird(string name, int positionX, int positionY, int positionZ) : base(name, positionX, positionY)
        {
            PositionZ = positionZ;
        }

        /// <summary>
        /// Makes the bird fly in a pattern
        /// Use SetPattern() with a list of FlyingPattern
        /// </summary>
        public abstract void Fly();

        /// <summary>
        /// Draws the bird position
        /// </summary>
        /// <returns>The birds current x and y position</returns>
        public override string Draw()
        {
            return $"{Name} Current position: {PositionX}, {PositionY}, {PositionZ}";
        }
    }
}
