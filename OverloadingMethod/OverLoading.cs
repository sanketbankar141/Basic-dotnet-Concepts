using System;

namespace OverloadingMethod
{
    class OverLoading
    {
        void Sum(int a)
        {

        }
        void Sum(float a)
        {

        }
        static void Main(string[] args)
        {
            OverLoading obj = new OverLoading();
            obj.Sum(10);
            Console.ReadLine();
        }
    }
}
