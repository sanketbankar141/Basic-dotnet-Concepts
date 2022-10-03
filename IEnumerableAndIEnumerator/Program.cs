using System;
using System.Collections.Generic;

namespace IEnumerableAndIEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> years = new List<int>();
            years.Add(2000);
            years.Add(2001);
            years.Add(2002);
            years.Add(2003);
            years.Add(2004);
            years.Add(2005);
            years.Add(2006);

            IEnumerable<int> ienum = (IEnumerable<int>)years;
            foreach (int i in ienum)
            {
                Console.WriteLine(i);
            }
        }
    }
}
