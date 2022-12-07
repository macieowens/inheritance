using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public int HeightInFeet { get; set; }

        public bool HasFeathers { get; set; }

        public string Nickname { get; set; }

        public string Color { get; set; } 

        public Bird()
        {

        }

        public Bird(int height, bool hasFeathers, string nickname, string color)
        {
            HeightInFeet = height;
            HasFeathers = hasFeathers;
            Nickname = nickname;
            Color = color;
        }


    }

}
