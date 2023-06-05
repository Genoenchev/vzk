using PersonEngine.Enums;

namespace PersonEngine.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public PersonStatus PersonStatus { get; set; }
        public PersonJob PersonJob { get; set; }
    }
}
