using System;

namespace ConstructorOverLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
     
        }

        class Pizza
        {
            string bread;
            string sauce;
            string cheese;
            string toppings;

            public Pizza(string bread, string sauce, string cheese, string toppings)
            {
                this.bread = bread;
                this.sauce = sauce;
                this.cheese = cheese;
                this.toppings = toppings;
            }
            public Pizza(string bread, string sauce, string cheese)
            {
                this.bread = bread;
                this.sauce = sauce;
                this.cheese = cheese;
            }
            public Pizza(string bread, string sauce)
            {
                this.bread = bread;
                this.sauce = sauce;
            }
        }
    }
}
