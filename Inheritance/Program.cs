using System;

namespace Inheritance
{
    class Program
    {
        // MultiLevel Inheritance 
        class Father
        {

        }

        class Mother : Father
        {

        }

        class Child : Mother 
        {

        }

        //Multiple Inheritance 
        interface IHonda
        {

        }
        interface IKia
        {

        }
        interface ICar : IHonda, IKia //In C# we can achive multiple Inheritance only on Interface 
        {

        }


        //Multiple Inheritance
       public class Chair
        {

        }
        public class Table
        {

        }
        public class Wood : Chair, Table
        {

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
