using System;

namespace EnumClass
{
    class Program
    {
        enum Week
        {
            Monday = 1,
            Tuesday = 2,
            Thursday = 11,
            Wednesday = 11
        }
        static void Main(string[] args)
        {
           int days = (int) Week.Tuesday;
            Console.WriteLine(days);
            Console.ReadLine();
        }
    }
}
