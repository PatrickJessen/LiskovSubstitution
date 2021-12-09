using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class Penguin : Bird
    {
        public Penguin(string name, int positionX, int positionY) : base(name, positionX, positionY)
        {
        }
    }
}
