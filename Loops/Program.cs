using System;

namespace Loops
{
    class LoopDifference

    {
        static void Main(string[] args)

        {
            const int MAX = 5;
            for (int i = 0; i < MAX; i++)
            {
                System.Console.WriteLine("For Loop : {0}", i);
            }

            int j = 6;

            while (j < MAX)
            {
                System.Console.WriteLine("While Loop : {0}", j);
                j++;
            }

            int k = 0;
            do
            {
                System.Console.WriteLine("Do While Loop : {0}", k);
                k++;
            } while (k < MAX);

        }

    }
}
