namespace LibraryManagament.Books
{
    public partial class Book
    {
        public Book(string title, string author, string[] address)
        {
            Title = title;
            Author = author;
            Address = address;
        }

        public string ToString()
            => $"{Author},{Title}";

        public string GetFloor()
            => Address[0];

        public string GetCloset()
            => Address[1];

        public string GetShelf()
            => Address[2];
    }
}
