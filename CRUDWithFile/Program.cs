using System.Text;

internal class Program
{
    private static void Main()
    {
        StringBuilder soz2 = new StringBuilder("");

        for (int i = 0; i < 100; i++)
        {
            soz2.Append(i);
        }

        soz2.Insert(2, "Sardor");
        soz2.Remove(2, 6);

        Console.WriteLine(soz2);


        /* Console.WriteLine("Hello, World!");

         //Repository - Service - bazaga crud

         var bookRepository = new BookRepository();
         //bookRepository.Add(new CRUDWithFile.Models.Book() { Id = 2, Title = "Garry Potter1", AuthorName = "Sardor", Genre = "Fantastika" });

         bookRepository.Delete(1);

         foreach (var book in bookRepository.GetBooks())
         {
             Console.WriteLine(book.Id + book.Title + book.AuthorName + book.Genre);
         }*/

    }
}