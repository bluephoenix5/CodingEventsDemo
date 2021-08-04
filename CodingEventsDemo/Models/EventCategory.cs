using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEventsDemo.Models
{
    public class EventCategory : Controller
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IActionResult Index()
        {
            return View();
        }

        public EventCategory()
        {

        }

        public EventCategory(string name)
        {
            Name = name;
        }
    }
}
