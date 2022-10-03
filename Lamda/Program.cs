using System;

namespace Lamda
{
    class Program
    {
        static void Main(string[] args)
        {
            //args => expression
            // int  sum = 5;
            // Func<int, int> Ans = s => s* sum;
            // var result = Ans(5);
            // Console.WriteLine( result);

            var books = new BookRepository().GetBooks();

           var cheapbooks = books.FindAll(x => x.Price < 100);

            foreach (var book in cheapbooks)
            {
                Console.WriteLine(book.Title);
            }


        }
    }
}
