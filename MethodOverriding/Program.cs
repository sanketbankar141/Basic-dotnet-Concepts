using System;

namespace MethodOverriding
{
    class Animal 
    {
        public virtual void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }

    class Dog : Animal
    {
        public override void Eat()
        {
            
        }

        //public  void Eat()
        //{
        //    Console.WriteLine("Dog is eating");
        //}
        public static void Main(string [] args)
        {
            Dog tommy = new Dog();
            tommy.Eat();
            Console.ReadLine();
        }
    }
}