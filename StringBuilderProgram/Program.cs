using System;
using System.Text;

namespace StringBuilderProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Sanket";

            StringBuilder sb = new StringBuilder(str);
            sb.Append(" Sudhir \nBankar");
            sb.Append("How are you");
            Console.WriteLine(sb);
        }
    }
}
