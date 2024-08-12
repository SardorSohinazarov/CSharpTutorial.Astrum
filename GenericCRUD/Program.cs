using GenericCRUD.Services.EventsService;

/*IEventLocationsService eventLocationsService = new EventLocationService();

eventLocationsService.CreateEventLocation(new GenericCRUD.Models.EventLocation()
{
    Id = 1,
    Name = "Xalqlar do'stligi",
    Capasity = 4200,
    Rows = 100,
    Sits = 42,
    Address = "Toshkent shaxar",
});

var events = eventLocationsService.GetAll();

foreach (var eventLocation in events)
{
    Console.WriteLine(JsonSerializer.Serialize(eventLocation, new JsonSerializerOptions() { WriteIndented = true }));
}*/

IEventService eventService = new EventService();
eventService.CreateEvent(new GenericCRUD.Models.Event()
{
    Id = 1,
    Name = "Ozodbek Nazarbekov",
    Price = 1000000,
    Start = new DateTime(2024, 11, 1, 21, 0, 0),
    End = new DateTime(2024, 12, 1, 19, 0, 0),
    EventLocationId = 1
});