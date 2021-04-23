using System;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffieTableBook ctBook = new CoffieTableBook();
            ctBook.Author = "Stephen King";
            ctBook.ISBN = 123456;
            ctBook.Title = "The Shining";
            ctBook.Price = 150.0;
            ctBook.Price = 40.0;

            Book book = new Book();
            book.Author = "J.R.R. Tolkien";
            book.ISBN = 456789;
            book.Title = "The Lord of the Rings, The return of the King";
            book.Price = 25.0;

            TextBook tBook = new TextBook();
            tBook.Author = "Tim Dams";
            tBook.ISBN = 123789;
            tBook.Title = "Zie Scherper";
            tBook.Price = 0.0;
            tBook.Price = 20.0;

            Console.WriteLine(ctBook);
            Console.WriteLine(tBook);
            Console.WriteLine(book);

            Console.WriteLine();

            Console.WriteLine(ctBook.Equals(book));
            book.ISBN = ctBook.ISBN;
            Console.WriteLine(ctBook.Equals(book));
            Console.WriteLine(book.Equals(ctBook));

            Book b = Book.Add(book, ctBook);
            Console.WriteLine(b);
        }
    }
}
