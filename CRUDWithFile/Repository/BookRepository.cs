using CRUDWithFile.Models;
using System.Text.Json;

namespace CRUDWithFile.Repository
{
    internal class BookRepository
    {
        string path = "C:\\Users\\sardo\\OneDrive\\Рабочий стол\\Projects\\C#Tutorial\\CRUDWithFile\\book.txt";

        public void Add(Book book)
        {
            var books = GetBooks();
            books.Add(book);
            File.WriteAllText(path, JsonSerializer.Serialize(books));
        }

        public List<Book> GetBooks()
        {
            var alltext = File.ReadAllText(path);
            var books = JsonSerializer.Deserialize<List<Book>>(alltext);
            return books;
        }

        public void Delete(int id)
        {
            var books = GetBooks();
            var book = books.FirstOrDefault(x => x.Id == id);

            books.Remove(book);

            File.WriteAllText(path, JsonSerializer.Serialize(books));
        }
    }
}
