using GenericCRUD.Models;
using GenericCRUD.Repositories.EventLocationsRepository;

namespace GenericCRUD.Services.EventLocationsService
{
    internal class EventLocationService : IEventLocationsService
    {
        public EventLocation CreateEventLocation(EventLocation eventLocation)
        {
            IEventLocationRepository repository = new EventLocationRepositoey();
            return repository.Insert(eventLocation);
        }

        public List<EventLocation> GetAll()
        {
            IEventLocationRepository repository = new EventLocationRepositoey();
            return repository.GetAll();
        }
    }
}
