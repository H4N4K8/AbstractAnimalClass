using System;
using System.Drawing;
using System.Xml.Linq;

namespace Animals
{
    abstract class Animal
    {
        // Property
        public abstract string Name { get; set; }
        // Methods
        public abstract string Describe();
        public string whatAmI()
        {
            return "I am an animal";
        }
    }

    class Program
    {
        class Cat : Animal
        {
            // override the abstract property
            public override string Name { get; set; }
            public string Type { get; set; }

            public string Color { get; set; }

            public Cat()
            {
                Name = string.Empty;
                Type = string.Empty;
                Color = string.Empty;
            }
            public Cat(string name, string type, string color)
            {
                Name = name;
                Type = type;
                Color = color;
            }
            // override the abstract method
            public override string Describe()
            {
                return "I am a "+ Color + " " + Type + "\nMy name is " + Name;
            }

        }
        static void Main(string[] args)
        {
            Cat grey = new Cat();
            grey.Name = "Snoop";
            grey.Type = "cat";
            grey.Color = "grey";
            Console.WriteLine(grey.whatAmI());
            Console.WriteLine(grey.Describe());

            Cat bonny = new Cat("bonny", "cat", "brown");
            Console.WriteLine(bonny.whatAmI());
            Console.WriteLine(bonny.Describe());
        }
    }
}