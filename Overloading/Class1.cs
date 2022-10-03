using System;

namespace Overloading
{
    public class Program
    {
        void Sum(int a)
        {

        }
        void Sum(float a)
        {

        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Sum(10);
            Console.ReadLine();
        }
    }
}
