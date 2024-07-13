using LibraryManagament.Books;
using LibraryManagament.Library;

internal class Program
{
    private static void Main(string[] args)
    {
        var library = new Library();

        var book = new Book("O'tkan kunlar", "Abdulla Qodiriy", new string[] { "1", "A1", "1" });

        library.Add(book);
        library.Add(new Book("Hamsa", "Alisher Navoiy", new string[] { "1", "A1", "2" }));
        library.Add(new Book("Molxona", "Jourje Orvel", new string[] { "1", "A1", "3" }));
        library.Add(new Book("Tom Soyer", "Mark Tven", new string[] { "1", "A1", "4" }));
        library.Add(new Book("J.F Authobiografiya", "Jaxongir Foziljonov", new string[] { "1", "A1", "5" }));
        library.Add(new Book("Bonu", "Iqbol Mirzo", new string[] { "1", "A2", "1" }));
        library.Add(new Book("Yulduzli tunlar", "Primqul Qodiriv", new string[] { "1", "A2", "2" }));
        library.Add(new Book("Boburnoma", "Muhammad Bobur", new string[] { "1", "A3", "3" }));


        Console.WriteLine(library.Find("Yulduzli tunlar"));
        Console.WriteLine(library.Find("Primqul Qodiriv", "Yulduzli tunlar"));
        Console.WriteLine(library.Find("Primqul Qodiriv"));

        Console.WriteLine(book.GetCloset());

        Console.WriteLine(library.Contains("sdkcs", "skjc", "skc"));
        Console.WriteLine(library.Contains("1", "A1", "3"));
    }
}