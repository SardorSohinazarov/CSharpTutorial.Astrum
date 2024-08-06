// See https://aka.ms/new-console-template for more information
using GenericCRUD.Models;
using GenericCRUD.Repositories.TicketsRepository;

Console.WriteLine("Hello, World!");

ITickectRepository tickectRepository = new TicketRepository();

tickectRepository.Insert(new Ticket() { Id = 1, Title = "Sardor" });

var values = tickectRepository.GetAll();

foreach (var value in values)
{
    Console.WriteLine(value.Title);
}