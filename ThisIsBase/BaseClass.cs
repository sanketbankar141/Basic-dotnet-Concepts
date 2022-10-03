using System;

namespace ThisIsBase
{
    public class C
    {
        public C(int i)
        {

        }

    }
    
    public class B : C
    {
        public B(int i) : base(i)
        {
            
        }
    }

    class BaseClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
