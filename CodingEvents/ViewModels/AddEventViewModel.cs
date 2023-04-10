﻿using System;
using System.ComponentModel.DataAnnotations;
using CodingEvents.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        [Required(ErrorMessage = "Category is required")]
        public int CategoryId { get; set; }
        public List<SelectListItem>? Categories { get; set;}

        public AddEventViewModel (List<EventCategory> categories) {

            Categories = new List<SelectListItem>();

            foreach (var category in categories)
            {
                Categories.Add(
                new SelectListItem
                {
                    Value = category.Id.ToString(),
                    Text = category.Name
                });
            }
        }

        public AddEventViewModel () 
        {
        }

    }
}
