using GenericCRUD.Models;

namespace GenericCRUD.Services.TicketsService
{
    internal interface ITicketService
    {
        Ticket CreateTicket(Ticket ticket);
        List<Ticket> GetAll();
        Ticket CancelTicket(string secret, int ticketId);
    }
}
