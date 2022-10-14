
namespace WindowsForms
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Product()
        {
            Name = "Unknown";
            Description = "Unknown";
            Price = 0;
        }
        public Product (string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Name}, {Description}, {Price}";
        }
    }
}
