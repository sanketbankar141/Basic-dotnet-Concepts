using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Word.Name(" Hello ");
            Console.ReadLine();

        }
    }
         class Word
        {
         public static void Name(string a)
        {
            Console.WriteLine($"Sanket{a}");
        }

        }

}
