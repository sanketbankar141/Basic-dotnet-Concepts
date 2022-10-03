using System;

namespace ArrayProgram
{
    class Program
    {
      
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };

            //Find Length of array 
            Console.WriteLine("Length " + numbers.Length);

            //Index of
            var Index = Array.IndexOf(numbers, 3);
            Console.WriteLine("Index of 3 is " + Index);

        }
    }
}
