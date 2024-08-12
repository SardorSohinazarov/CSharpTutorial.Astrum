namespace GenericCRUD.Models
{
    internal class Ticket
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int EventId { get; set; }
        public int Row { get; set; }
        public int Seat { get; set; }
        public string SecretCode { get; set; }
    }
}
