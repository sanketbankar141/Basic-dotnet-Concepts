using System;

namespace GenericClass
{
    class GenecricClass<S>
    {
        public S MyProperty { get; set; }
        public void Method(S p1)
        {

        }
        
    }
    class Person
    {
        static void Main(string[] args)
        {
            GenecricClass<int> obj1 = new GenecricClass<int>();
            obj1.MyProperty = 10;
            obj1.Method(10);
        }
    }       
}
