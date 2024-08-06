using GenericCRUD.Models;

namespace GenericCRUD.Repositories.TicketsRepository
{
    internal class TicketRepository : BaseRepository<int, Ticket>, ITickectRepository
    {
        public TicketRepository()
        {
        }
    }
}
