using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public string Texture { get; set; }

        public string Color { get; set; }

        public int HowManyLegs { get; set; }

        public bool HasScales { get; set; }

        public Reptile()
        {

        }

        public Reptile(string texture, string color, int howManyLegs, bool hasScales)
        {
            Texture = texture;
            Color = color;
            HowManyLegs = howManyLegs;
            HasScales = hasScales;
        }
    }
}
