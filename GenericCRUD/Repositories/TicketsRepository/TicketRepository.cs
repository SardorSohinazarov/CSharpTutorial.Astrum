using GenericCRUD.Models;

namespace GenericCRUD.Repositories.TicketsRepository
{
    internal class TicketRepository : BaseRepository<int, Ticket>, ITicketRepository
    {
        public TicketRepository()
        {
        }
    }
}
