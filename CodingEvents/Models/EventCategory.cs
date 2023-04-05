namespace CodingEvents.Models
{
    public class EventCategory
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public EventCategory()
        {
        }

        public EventCategory(string name)
        {
            Name = name;
        }

        public override bool Equals(object? obj)
        {
            return obj is EventCategory category &&
                   Id == category.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string? ToString()
        {
            return Name;
        }
    }
}
