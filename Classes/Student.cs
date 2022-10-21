
namespace WindowsForms
{
    public class Student
    {
        public string Group { get; set; }
        public string FullName { get; set; }
        public DateOnly Birthday { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }

        public Student ()
        {
            Group = "Unknown";
            FullName = "Unknown";
            Birthday = new DateOnly(0, 0, 0);
            Height = "Unknown";
            Weight = "Unknown";
        }
        public Student (string group, string fullName, DateOnly birthday, string height, string weight)
        {
            Group = group;
            FullName = fullName;
            Birthday = birthday;
            Height = height;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"{Group}, {FullName}, {Birthday}, {Height}, {Weight}";
        }
    }
}
