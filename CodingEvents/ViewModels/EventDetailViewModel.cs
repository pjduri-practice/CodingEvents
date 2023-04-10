namespace CodingEvents.ViewModels
{
    public class EventDetailViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContactEmail { get; set; }
        public string CategoryName { get; set; }

        public EventDetailViewModel(EventDetailViewModel theEvent) 
        {
            Name = theEvent.Name;
            Description = theEvent.Description;
            ContactEmail = theEvent.ContactEmail;
            CategoryName = theEvent.Category.Name;
        }
    }
}
