using CRUDWithFile.Models;

namespace CRUDWithFile.Repository
{
    internal class BookRepository
    {
        string path = "C:\\Users\\sardo\\OneDrive\\Рабочий стол\\Projects\\C#Tutorial\\CRUDWithFile\\book.txt";

        public void Add(Book book)
            => File.AppendAllText(path, $"\n{book.Id} {book.Title} {book.AuthorName} {book.Genre}");

        public List<Book> GetBooks()
        {
            var lines = File.ReadAllLines(path);

            var books = new List<Book>();

            foreach (var line in lines)
            {
                var lineWords = line.Split(" ");

                books.Add(new Book()
                {
                    Id = int.Parse(lineWords[0]),
                    Title = lineWords[1],
                    AuthorName = lineWords[2],
                    Genre = lineWords[3]
                });
            };
            /*   var books = lines.Select(x => new Book()
               {
                   Id = int.Parse(x.Split(" ")[0]),
                   Title = x.Split(" ")[1],
                   AuthorName = x.Split(" ")[2],
                   Genre = x.Split(" ")[3],
               });*/

            return books.ToList();
        }

        public void Delete(int id)
        {
            var books = GetBooks();
            var book = books.FirstOrDefault(x => x.Id == id);

            books.Remove(book);

            File.WriteAllLines(path, books.Select(x => $"{x.Id} {x.Title} {x.AuthorName} {x.Genre}"));
        }
    }
}
