using Nimadur.Models;
using Nimadur.Services.Books;
using Telegram.Bot;

internal class Program
{
    private static void Main(string[] args)
    {
        Action<IEnumerable<Book>> logger = new Action<IEnumerable<Book>>(LogToConsole);
        logger += LogToFile;
        logger += LogToTelegramBot;

        Console.WriteLine("Hello, World!");

        IBookService bookService = new BookService();

        bookService.Add(new Book
        {
            Id = 1,
            Title = "C#",
            Author = "Nimadur",
            ISBN = "123456",
            Price = 100
        });

        bookService.Add(new Book() { Id = 2, Title = "Java", Author = "Sardor", ISBN = "123456", Price = 10 });
        bookService.Add(new Book() { Id = 3, Title = "Python", Author = "Nimadur", ISBN = "123456", Price = 1 });


        var books = bookService.Filter(
            func: x => x.Price > 0 && x.Author.Contains("Sardor"),
            action: logger
            );


        foreach (var book in books)
        {
            Console.WriteLine($"Id: {book.Id}, Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Price: {book.Price}");
        }
    }

    static void LogToTelegramBot(IEnumerable<Book> books)
    {
        new TelegramBotClient("7417598765:AAEBGNq-n5eunmSbz_lMPQtO2DPgek7a9FE")
            .SendTextMessageAsync(5617428170, books.Count().ToString())
            .Wait();
    }


    static void LogToConsole(IEnumerable<Book> books)
    {
        Console.WriteLine(books.Count());
    }

    static void LogToFile(IEnumerable<Book> books)
    {
        File.WriteAllText("C:\\Users\\sardo\\OneDrive\\Рабочий стол\\Projects\\C#Tutorial\\Nimadur\\log.txt", books.Count().ToString());
    }
}



