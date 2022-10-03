using System;
using System.Collections;

namespace StackProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push("Sanket");
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(null);
            myStack.Push("Top Of Stack");

            
            Console.WriteLine($"The Length of stack= {myStack.Count}");

            Console.WriteLine($"The POP of stack is{myStack.Pop()}");

            myStack.Pop();

            Console.WriteLine($"The peak of stack is{myStack.Peek()}");

            Console.WriteLine($"The Length of stack= {myStack.Count}");

            myStack.Clear();

            Console.WriteLine($"myStack has a 2 = {myStack.Contains(3)}");


            foreach (var stackItem in myStack)
            {
                Console.WriteLine(stackItem);
            }
        }
    }
}
