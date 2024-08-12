using GenericCRUD.Models;

namespace GenericCRUD.Services.EventLocationsService
{
    internal interface IEventLocationsService
    {
        EventLocation CreateEventLocation(EventLocation eventLocation);
        List<EventLocation> GetAll();
    }
}
