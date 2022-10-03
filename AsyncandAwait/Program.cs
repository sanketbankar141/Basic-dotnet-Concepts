using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncandAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static async void Method()
        {
            await Task.Run(new Action(LongTask));
            Console
        }

        public static void LongTask()
        {
            Thread.Sleep(20000);
        }
    }
}
