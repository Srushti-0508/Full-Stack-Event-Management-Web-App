using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using soft20181_starter.Models;

namespace soft20181_starter.Pages
{
    [Authorize(Roles = "Admin")]
    public class EditEventModel : PageModel
    {

		[BindProperty(SupportsGet = true)]
		public int Id { get; set; }

		private readonly EventAppDbContext dbContext;
		public EditEventModel(EventAppDbContext _db)
		{
			dbContext = _db;
		}

		//-----Expose the TheEvent (data model) class as a public property------//
		[BindProperty]
		public TheEvent theEvent { get; set; }

		//------handler would implement the find method to query the database using the Id as the primary
		//key and return data for a unique event------//

		public void OnGet()
		{
			theEvent = dbContext.Events.Find(Id);
		}

		public IActionResult OnPost()
		{
			if (ModelState.IsValid)
			{
				dbContext.Events.Update(theEvent);
				dbContext.SaveChanges();
				return RedirectToPage("editDltEvent");
			}
			else
			{
				return Page();
			}


			//dbContext.Events.Update(theEvent);
			//	dbContext.SaveChanges();
			//	return RedirectToPage("Events");
			//}
			//else
			//{
			//	return Page();
		}


		public IActionResult OnGetDelete()
		{
			//----Use this method to permentally delete the record
			dbContext.Remove(dbContext.Events.Find(Id));
			dbContext.SaveChanges();
			return RedirectToPage("Events");

			//var eventToDelete= dbContext.Events.Find(Id);
			//if (eventToDelete != null)
			//{
			//	eventToDelete.IsDeleted = true;
			//	dbContext.SaveChanges();
			//}
			//return RedirectToPage("Events");
		}
	}
}
   
