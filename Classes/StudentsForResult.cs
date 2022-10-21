
namespace WindowsForms
{
    public class StudentsForResult
    {
        public string Group { get; set; }
        public string FullName { get; set; }
        public int Quantity { get; set; }

        public StudentsForResult ()
        {
            Group = "Unknown";
            FullName = "Unknown";
            Quantity = 0;
        }
        public StudentsForResult (string group, string fullName, int quantity)
        {
            Group = group;
            FullName = fullName;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"{Group}, {FullName}, {Quantity}";
        }
    }
}
