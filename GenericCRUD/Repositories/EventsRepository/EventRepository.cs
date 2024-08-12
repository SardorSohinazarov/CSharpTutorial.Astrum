using GenericCRUD.Models;

namespace GenericCRUD.Repositories.EventsRepository
{
    internal class EventRepository : BaseRepository<int, Event>, IEventRepository
    {
        public EventRepository()
        {

        }
    }
}
