
namespace WindowsForms
{
    public class WorkersForResult
    {
        public string Surname { get; set; }
        public int Age { get; set; }

        public WorkersForResult ()
        {
            Surname = "Unknown";
            Age = 0;
        }
        public WorkersForResult (string surname, int age)
        {
            Surname = surname;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Surname}, {Age}";
        }
    }
}
