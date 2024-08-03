using CRUD.Models;
using CRUD.Services.Persons;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        PersonService personService = new PersonService();

        personService.Create(new Person { Id = 1, Name = "Astrum1" });
        personService.Create(new Person { Id = 2, Name = "Astrum2" });
        personService.Create(new Person { Id = 3, Name = "Astrum3" });

        var persons = personService.Filter(
            x => x.Name.Contains("Astrum"),
            y => Console.WriteLine($"filtered {y.Count()} rows"));
    }
}