using System;
using System.Diagnostics;

namespace StopWatchProgram
{ 
    class Program
    {
        public static void Main(string[] args)
        {
            var watch = Stopwatch.StartNew();
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i + "\n");
            }
            
            watch.Stop();
            Console.WriteLine($"Execution Time : { watch.ElapsedMilliseconds} MilliSeconds.");
        }
    }
}
