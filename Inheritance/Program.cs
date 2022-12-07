using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird Emu = new Bird()
            {
                HeightInFeet = 6,
                HasFeathers = true,
                Nickname = "Tall Boy",
                Color = "Pink"

            };

            Console.WriteLine($"The Emu - " +
                $"This majestic bird is the tallest bird known to man, being {Emu.HeightInFeet}ft tall. " +
                $"It is {Emu.HasFeathers} that these birds have many {Emu.Color} feathers, even though they cannot fly. " +
                $"Some people call this bird {Emu.Nickname}.");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile SlytherinSnake = new Reptile()
            {
                Texture = "Slimy",
                Color = "Neon Green",
                HowManyLegs = 14,
                HasScales = true,
            };

            Console.WriteLine($"My favorite reptile is the Slytherin Snake. " +
                $"It is {SlytherinSnake.HasScales} that they have scales and a {SlytherinSnake.Texture} texture, but unlike other snakes they have a beautiful, bright {SlytherinSnake.Color} color. " +
                $"Unlike other snakes, the Slytherin Snake has {SlytherinSnake.HowManyLegs} legs."); 

        }
    }
}
