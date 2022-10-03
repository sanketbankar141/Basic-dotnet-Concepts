using System;
using System.Collections.Generic;

namespace ListProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1,2,3,4,5};
            numbers.Add(10);
            numbers.AddRange(new int[2] {3,4});
           foreach(var number in numbers )
           {
                Console.WriteLine($"Added numbers are {number}");
           }
        }
    }
}
