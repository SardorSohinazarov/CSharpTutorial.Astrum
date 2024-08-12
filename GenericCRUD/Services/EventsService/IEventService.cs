using GenericCRUD.Models;

namespace GenericCRUD.Services.EventsService
{
    internal interface IEventService
    {
        Event CreateEvent(Event _event);
        List<Event> GetAll();
    }
}
