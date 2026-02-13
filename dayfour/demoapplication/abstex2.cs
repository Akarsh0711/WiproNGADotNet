using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.DemoApp
{
    abstract class AbstractCreature
    {
        public abstract void DisplayName();
        public abstract void DisplayType();
    }

    class Reptile : AbstractCreature
    {
        public override void DisplayName()
        {
            Console.WriteLine("Species: Crocodile");
        }

        public override void DisplayType()
        {
            Console.WriteLine("Type: Semi-Aquatic Reptile");
        }
    }

    class Herbivore : AbstractCreature
    {
        public override void DisplayName()
        {
            Console.WriteLine("Species: Cow");
        }

        public override void DisplayType()
        {
            Console.WriteLine("Type: Mammal");
        }
    }

    class Carnivore : AbstractCreature
    {
        public override void DisplayName()
        {
            Console.WriteLine("Species: Lion");
        }

        public override void DisplayType()
        {
            Console.WriteLine("Type: Wild Animal");
        }
    }

    internal class CreatureDemo
    {
        static void Main()
        {
            AbstractCreature[] zoo = new AbstractCreature[]
            {
                new Carnivore(), new Reptile(), new Herbivore()
            };
            foreach(AbstractCreature creature in zoo)
            {
                creature.DisplayName();
                creature.DisplayType();
            }
        }
    }
}
