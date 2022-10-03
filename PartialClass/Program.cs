using System;

namespace PartialClass
{
    class Program
    {
        public partial class Hello
        {
            public void abc()
            {

            }
        }

        public partial class Hello
        {
            public void abc1()
            {

            }
        }

        static void Main(string[] args)
        {
            Hello hello = new Hello();
            hello.abc1();
            Console.WriteLine("");
        }
    }
}
