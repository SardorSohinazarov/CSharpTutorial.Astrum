namespace GenericCRUD.Models
{
    internal class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public decimal Price { get; set; }
        public int EventLocationId { get; set; }
    }
}
