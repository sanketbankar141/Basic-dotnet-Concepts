using System;
using System.Collections.Generic;
using System.Text;

namespace Overloading
{
    public class Class2
    {
        public void Sum( int A)
        {
            
        }

        public void Sum (float B)
        {

        }

        static void Main(string[] args)
        {
            Class2 c2 = new Class2();
            c2.Sum(2);
            Console.ReadLine();
        }



    }
}
