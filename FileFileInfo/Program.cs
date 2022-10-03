using System;
using System.IO;

namespace FileFileInfo
{
    class Program
    {
       
        static void Main(string[] args)
        {
            try
            {
                string Sanket  = "C:ABC\\sam.txt";

                FileInfo file = new FileInfo(Sanket);
                file.Create();
                Console.WriteLine("File Created Successfully Please go to specified Path ");


            }
            catch (IOException e)
            {
                Console.WriteLine(" File has not Created" + e);
            }
            Console.ReadLine();
        }
    }
}
