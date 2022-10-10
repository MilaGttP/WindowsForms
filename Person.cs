
namespace WindowsForms
{
    public class Person
    {
        public string Surname { get; set; }
        public int Salary { get; set; }
        public string Position { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int House { get; set; }

        public Person()
        {
            Surname = "Unknown";
            Salary = 0;
            Position = "Unknown";
            City = "Unknown";
            Street = "Unknown";
            House = 0;
        }
        public Person(string surname, int salary, string position, string city, string street, int house)
        {
            Surname = surname;
            Salary = salary;
            Position = position;
            City = city;
            Street = street;
            House = house;
        }
        public override string ToString()
        {
            return $"{Surname},  {Salary},  {Position},  {City},  {Street},  {House}";
        }
    }
}
