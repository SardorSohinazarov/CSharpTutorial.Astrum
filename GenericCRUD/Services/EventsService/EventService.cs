using GenericCRUD.Models;
using GenericCRUD.Repositories.EventsRepository;

namespace GenericCRUD.Services.EventsService
{
    internal class EventService : IEventService
    {
        public Event CreateEvent(Event _event)
        {
            IEventRepository eventRepository = new EventRepository();

            var events = eventRepository.GetAll();

            foreach (var @event in events)
            {
                var beforeDifferense = @event.End - _event.Start;
                var afterDifferense = _event.End - @event.Start;

                if (!((Math.Abs(beforeDifferense.Hours) > 1 && @event.End > _event.Start)
                    || (Math.Abs(afterDifferense.Hours) > 1 && @event.End < _event.Start)))
                    throw new Exception("Vaqt to'g'ri kelmaydi");
            }

            return eventRepository.Insert(_event);
        }

        public List<Event> GetAll()
            => new EventRepository().GetAll();
    }
}
