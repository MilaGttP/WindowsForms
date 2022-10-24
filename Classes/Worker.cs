
namespace WindowsForms
{
    public class Worker
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public DateOnly Birthday { get; set; }
        public string City { get; set; }

        public Worker ()
        {
            Surname = "Unknown";
            Name = "Unknown";
            Patronymic = "Unknown";
            Birthday = new DateOnly(0001, 1, 1);
            City = "Unknown";
        }
        public Worker (string surname, string name, string patronymic, DateOnly birthday, string city)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Birthday = birthday;
            City = city;
        }

        public override string ToString()
        {
            return $"{Surname}, {Name}, {Patronymic}, {Birthday}, {City}";
        }
    }
}
