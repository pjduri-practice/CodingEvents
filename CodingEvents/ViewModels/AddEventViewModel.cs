using System;
using System.ComponentModel.DataAnnotations;

namespace CodingEvents.ViewModels
{
	public class AddEventViewModel
	{
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter a description for your event.")]
        [StringLength(500, ErrorMessage = "Description is too long!")]
        public string? Description { get; set; }

		[EmailAddress]
		public string? ContactEmail { get; set; }

        [Required(ErrorMessage = "Enter Location")]
        [StringLength(140, MinimumLength = 25, ErrorMessage = "Please enter a valid address.")]
        public string? Location { get; set; }

        [Required(ErrorMessage = "How many people are coming")]
        [Range(0, 100000, ErrorMessage = "Enter a valid attendance number between 0 and 100000")]
        public int? Attendees { get; set; }
	}
}
