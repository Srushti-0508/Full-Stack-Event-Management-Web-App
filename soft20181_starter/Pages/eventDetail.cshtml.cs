using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using soft20181_starter.Models;

namespace soft20181_starter.Pages
{
    public class eventDetailModel : PageModel
    {
        private readonly EventAppDbContext _dbcontext;


        public eventDetailModel(EventAppDbContext dbcontext)
        {
			_dbcontext = dbcontext;
        }

		public TheEvent Event { get; set; }
		public List<TheEvent>EventSuggestions { get; set; }

		public async Task<IActionResult> OnGetAsync(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			Event = await _dbcontext.Events.FindAsync(id);

			if (Event == null)
			{
				return NotFound();
            }
			var EventList= await _dbcontext.Events.ToListAsync();
			EventSuggestions = EventList.OrderBy(e => new Random().Next()).Take(3).ToList();
            return Page();
        }

        //https://www.webtrainingroom.com/linq/random
    }
}


