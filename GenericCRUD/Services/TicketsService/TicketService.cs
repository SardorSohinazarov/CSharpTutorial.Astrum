using GenericCRUD.Models;
using GenericCRUD.Repositories.EventsRepository;
using GenericCRUD.Repositories.TicketsRepository;

namespace GenericCRUD.Services.TicketsService
{
    internal class TicketService : ITicketService
    {
        public Ticket CancelTicket(string secret, int ticketId)
        {
            ITicketRepository tickectRepository = new TicketRepository();
            IEventRepository eventRepository = new EventRepository();

            var tickets = tickectRepository.GetAll();

            Ticket ticket = null;

            foreach (var _ticket in tickets)
            {
                if (_ticket.Id == ticketId && _ticket.SecretCode == secret)
                    ticket = _ticket;
            }

            if (ticket == null)
                throw new Exception("Bilet topilmadi");

            var events = eventRepository.GetAll();

            foreach (var @event in events)
            {
                var diffrence = DateTime.Now - @event.Start;
                if (!(@event.Id == ticket.EventId && diffrence.Hours > 24))
                {
                    throw new Exception("24 soatdan kam vaqt qoldi");
                }
            }

            return tickectRepository.Delete(ticketId);
        }

        public Ticket CreateTicket(Ticket ticket)
        {
            ITicketRepository tickectRepository = new TicketRepository();

            var tickets = tickectRepository.GetAll();

            foreach (var _ticket in tickets)
            {
                if (_ticket.Row == ticket.Row && _ticket.Seat == ticket.Seat)
                    throw new Exception("Oldindan band qilingan");
            }

            ticket.SecretCode = Guid.NewGuid().ToString();

            return new TicketRepository().Insert(ticket);
        }

        public List<Ticket> GetAll()
        {
            return new TicketRepository().GetAll();
        }
    }
}
