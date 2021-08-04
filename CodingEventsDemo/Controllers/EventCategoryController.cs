using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using CodingEventsDemo.Data;
using CodingEventsDemo.Models;

namespace CodingEventsDemo.Controllers
{
    public class EventCategoryController : Controller
    {
        private EventDbContext _context;
        public EventCategoryController(EventDbContext dbContext)
        {
            _context = dbContext;
        }
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.title = "All Categories";
            List<EventCategory> categories = _context.Categories.ToList();
            return View(categories);
        }
    }
}
