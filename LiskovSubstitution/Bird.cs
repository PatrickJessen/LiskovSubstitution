using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    /// <summary>
    /// This class represents a bird
    /// </summary>
    public class Bird
    {
        public string Name { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public List<Pattern> Pattern { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Name of the bird</param>
        /// <param name="positionX">X position of the bird</param>
        /// <param name="positionY">Y position of the bird</param>
        public Bird(string name, int positionX, int positionY)
        {
            Name = name;
            PositionX = positionX;
            PositionY = positionY;
        }

        /// <summary>
        /// Moves the birds x and y position
        /// </summary>
        public void Move()
        {
            while (true)
            {
                for (int i = 0; i < Pattern.Count; i++)
                {
                    PositionX = Pattern[i].PositionX;
                    PositionY = Pattern[i].PositionY;
                    Thread.Sleep(500);
                }
            }
        }

        /// <summary>
        /// Sets the pattern the bird should be moving in
        /// </summary>
        /// <param name="pattern">List of the x and y positions the bird should move in</param>
        public virtual void SetPattern(List<Pattern> pattern)
        {
            this.Pattern = pattern;
        }

        /// <summary>
        /// Draws the bird position
        /// </summary>
        /// <returns>The birds current x and y position</returns>
        public virtual string Draw()
        {
            return $"{Name} Current position: {PositionX}, {PositionY}";
        }
    }
}
