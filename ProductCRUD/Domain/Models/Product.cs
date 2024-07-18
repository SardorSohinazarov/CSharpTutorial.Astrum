namespace ProductCRUD.Domain.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Id = Guid.NewGuid();
            Name = name;
            Price = price;
        }
    }
}
