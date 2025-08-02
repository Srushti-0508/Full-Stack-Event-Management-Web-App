using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using soft20181_starter.Models;

namespace soft20181_starter.Pages
{
    [Authorize(Roles = "Admin")]
    public class AddEventModel : PageModel
    {
		private readonly EventAppDbContext dbContext;

		[BindProperty]
		public TheEvent theEvent { get; set; }
		public AddEventModel(EventAppDbContext _db)
		{
			dbContext = _db;
			theEvent = new TheEvent();
		}

		public List<TheEvent> Events { get; set; }

		public void OnGet()
        {
        }

		public IActionResult OnPost()
		{
			dbContext.Events.Add(theEvent);
			dbContext.SaveChanges();

			return RedirectToPage("adminDashboard");

		}
	}
}
