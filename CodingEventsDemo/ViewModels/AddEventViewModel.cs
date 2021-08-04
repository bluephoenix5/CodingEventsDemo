using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CodingEventsDemo.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CodingEventsDemo.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description too long!")]
        public string Description { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }

        public EventType Type { get; set; }

        public List<SelectListItem> EventTypes { get; set; }
        public AddEventViewModel()
        {
            EventTypes = new List<SelectListItem>();
            EventTypes.Add(new SelectListItem
            {
                Value = EventType.Conference.ToString(),
                Text = EventType.Conference.ToString()
            });
            EventTypes.Add(new SelectListItem
            {
                Value = EventType.Meetup.ToString(),
                Text = EventType.Meetup.ToString()
            });
            EventTypes.Add(new SelectListItem
            {
                Value = EventType.Social.ToString(),
                Text = EventType.Social.ToString()
            });
            EventTypes.Add(new SelectListItem
            {
                Value = EventType.Workshop.ToString(),
                Text = EventType.Workshop.ToString()
            });
        }

    }
}
