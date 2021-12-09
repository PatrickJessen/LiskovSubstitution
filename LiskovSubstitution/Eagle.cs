using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class Eagle : FlyingBird
    {
        public Eagle(string name, int positionX, int positionY, int positionZ) : base(name, positionX, positionY, positionZ)
        {
        }

        public override void Fly()
        {
            while (true)
            {
                for (int i = 0; i < Pattern.Count; i++)
                {
                    PositionX = Pattern[i].PositionX;
                    PositionY = Pattern[i].PositionY;
                    PositionZ = ((FlyPattern)Pattern[i]).PositionZ;
                    Thread.Sleep(500);
                }
            }
        }
    }
}
