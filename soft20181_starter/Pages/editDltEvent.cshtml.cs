using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using soft20181_starter.Models;

namespace soft20181_starter.Pages
{
    [Authorize(Roles = "Admin")]
    public class EditDeleteEventModel : PageModel
    {
		private readonly EventAppDbContext dbContext;
		public List<TheEvent> Events { get; set; }

		public EditDeleteEventModel(EventAppDbContext _db)
		{
			dbContext = _db;

		}
		public void OnGet()
        {
			Events = dbContext.Events.ToList();
		}
    }
}
