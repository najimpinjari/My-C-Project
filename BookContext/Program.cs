using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BookContext
{
    class Program
    {
        static void Main()
        {
            using (var context = new BookContext())
            {
                context.Database.EnsureCreated(); // Ensure the database is created

                while (true)
                {
                    Console.WriteLine("\nOptions:");
                    Console.WriteLine("1. Add Book");
                    Console.WriteLine("2. List Books");
                    Console.WriteLine("3. Exit");

                    Console.Write("Enter your choice (1-3): ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            AddBook(context);
                            break;
                        case "2":
                            ListBooks(context);
                            break;
                        case "3":
                            Console.WriteLine("Exiting the application. Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                            break;
                    }
                }
            }
        }

        static void AddBook(BookContext context)
        {
            Console.Write("Enter the title of the book: ");
            string title = Console.ReadLine();

            Console.Write("Enter the author of the book: ");
            string author = Console.ReadLine();

            var newBook = new Book { Title = title, Author = author };
            context.Books.Add(newBook);
            context.SaveChanges();

            Console.WriteLine("Book added successfully!");
        }

        static void ListBooks(BookContext context)
        {
            var books = context.Books.ToList();

            if (books.Count == 0)
            {
                Console.WriteLine("No books in the database.");
            }
            else
            {
                Console.WriteLine("List of Books:");
                foreach (var book in books)
                {
                    Console.WriteLine($"- {book.Title} by {book.Author}");
                }
            }
        }
    }
    //class Program
    //{
    //    static void main()
    //    {
    //        using (var context = new BookContext())
    //        {
    //            context.database.EnsureCreated(); //ensure the database is crated 

    //            while (true)
    //            {
    //                Console.WriteLine("\nOptions");
    //                Console.WriteLine("1 add book");
    //                Console.WriteLine("2 list book");
    //                Console.WriteLine("3 Exit");

    //                Console.WriteLine("Enter your choice (1-3) : ");
    //                string choice = Console.ReadLine();

    //                switch (choice)
    //                {

    //                    case "1":
    //                        AddBook(context);
    //                        break:
    //                case "2":
    //                        Listbook(Context):
    //                    break;
    //                    case "3":
    //                        Console.WriteLine("Exiting the application . goodbye ");
    //                        return;

    //                    default:
    //                        Console.WriteLine("Invalid choice . Please enter a number between 1 aqnd 3 ");
    //                        break;
    //                }

    //            }
    //        }

    //    }
    //    static void AddBook(BookContext context)
    //    {
    //        Console.WriteLine("Enter the title of the book : ");
    //        string title = Console.ReadLine();

    //        Console.Write("Enter the author of the book : ");
    //        string author = Console.ReadLine();

    //        var newBook = new Book { title = title, author = author };
    //        context.Books.Add(newBook);
    //        context.SaveChanges();

    //        Console.WriteLine("Book added successfully ! ");
    //    }
    //    static void Main  ListBooks(BookContext context)
    //    {
    //        var book = context.Books.Tolist();

    //        if (books.count == 0)
    //        {
    //            Console.WriteLine("no books in the database ");
    //        }
    //        else
    //        {
    //            Console.WriteLine("List of Books : ");
    //            foreach( var Book in Books)
    //            {
    //                Console.WriteLine($" - {book.title} by {book.author}");
    //            }
    //        }

    //    }
    //}
}