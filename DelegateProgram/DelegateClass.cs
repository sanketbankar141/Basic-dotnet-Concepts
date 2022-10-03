
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProgram
{
    public delegate void StringDelegate(string text);
    public class DelegateClass
    {
        public static void Main(string[]args)
        {
            StringDelegate stringDelegate = ToUpperCase;
            stringDelegate("This is UpperCase");
            stringDelegate.Invoke("this is another UpperCase");
        }

        static void ToUpperCase(string text) => Console.WriteLine(text.ToUpper());
        static void ToLowerCase(string text) => Console.WriteLine(text.ToUpper());
    }
}
