using System;

namespace GenericClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            Check<int> check = new Check<int>();
            bool obj = check.Compare(1, 2);
            Console.WriteLine($"value is {obj}");

            Check<string> objString = new Check<string>();
            bool b2 = objString.Compare("Shiv", "Shiv");
            Console.WriteLine($"value is {b2}");
        }

        class Check<UNKNOWNDATATYPE>
        {
            public bool Compare(UNKNOWNDATATYPE i, UNKNOWNDATATYPE y)
            {
                if (i.Equals(y))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
