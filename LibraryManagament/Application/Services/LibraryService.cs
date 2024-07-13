using LibraryManagament.Books;

namespace LibraryManagament.Library
{
    public partial class Library
    {
        public Library()
        {
            Books = new List<Book>();
        }

        public void Add(Book book)
        {
            Books.Add(book);
        }

        public bool Contains(string floor, string closet, string shelf)
        {
            foreach (var book in Books)
            {
                if (
                    book.GetFloor() == floor
                    && book.GetCloset() == closet
                    && book.GetShelf() == shelf)
                {
                    return true;
                }
            }
            return false;
        }

        public string GetBooks(string closet)
        {
            var books = new List<string>();

            foreach (var book in Books)
            {
                if (book.GetCloset() == closet)
                    books.Add(book.ToString());
            }

            return string.Join(",\n", books);
        }

        public string Find(string author, string title)
        {
            var books = new List<string>();

            foreach (var book in Books)
            {
                if (book.Author == author && book.Title == title)
                    books.Add(book.ToString());
            }

            return string.Join(",\n", books);
        }

        public string Find(string text)
        {
            var books = new List<string>();

            foreach (var book in Books)
            {
                if (book.Author == text || book.Title == text)
                    books.Add(book.ToString());
            }

            return string.Join(",\n", books);
        }
    }
}
