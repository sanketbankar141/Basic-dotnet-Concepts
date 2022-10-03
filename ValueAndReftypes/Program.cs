using System;

namespace ValueAndReftypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Refe obj = new Refe();
            obj.i = 10;
            Refe obj1 = new Refe();
            obj1.i = 20;
            Console.WriteLine($"value of i is {obj1}");
        }

        public class Refe
        {
            public int i;
        }
      
    }
}
