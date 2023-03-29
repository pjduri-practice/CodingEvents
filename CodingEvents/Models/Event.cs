using System;
namespace CodingEvents.Models
{
	public class Event
	{
		public string? Name { get; set; }
		public string? Description { get; set; }
		public string? ContactEmail { get; set; }
		public string? Location { get; set; }
		public int? Attendees { 
			get { return Attendees; }
			set
			{
				Attendees = value;
			} 
		}

		public int Id { get; set; }
		static private int nextId = 1;

		public Event()
		{
			Id = nextId;
			nextId++;
		}

		public Event(string name, string description, string contactEmail, string location, int attendees): this()
		{
			Name = name;
			Description = description;
			ContactEmail = contactEmail;
			Location = location;
			Attendees = attendees;
		}

        public override string? ToString()
        {
            return Name;
        }

        public override bool Equals(object? obj)
        {
			return obj is Event @event && Id == @event.Id;
        }

        public override int GetHashCode()
        {
			return HashCode.Combine(Id);
        }
    }
}