using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using soft20181_starter.Models;

namespace soft20181_starter.Pages
{
    public class EventsModel : PageModel
    {
        private readonly EventAppDbContext dbContext;
        public List<TheEvent> Events { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Search {  get; set; }

        public bool Filter {  get; set; }
        public EventsModel(EventAppDbContext _db)
        {
            dbContext = _db;

        }
        public void OnGet()
        {
            bool filter = false;
            List<TheEvent> events = dbContext.Events.ToList();
            if (!string.IsNullOrEmpty(Search))
            {
				//Using ToUpper to make the search functionality case-insensitive. 
                //https://learn.microsoft.com/en-us/aspnet/core/data/ef-rp/sort-filter-page?view=aspnetcore-8.0
				events = events.Where(e=>e.Name.ToUpper().Contains(Search.ToUpper()) 
                                || e.Location.ToUpper().Contains(Search.ToUpper())).ToList();
                filter = true;
            }
            Events= events;
            Filter = filter;
        }
    }
}
