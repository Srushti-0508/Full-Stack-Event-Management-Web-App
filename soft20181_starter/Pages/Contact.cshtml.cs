using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using soft20181_starter.Models;

namespace soft20181_starter.Pages
{
    public class ContactModel : PageModel
    {
        private readonly EventAppDbContext dbContext;
        [BindProperty]
        public Contact ContactInfo { get; set; }
        public bool Save { get; set; }
        public List<Contact> Contacts { get; set; }

        public ContactModel(EventAppDbContext _db)
        {
            dbContext = _db;
           
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                dbContext.Contacts.Add(ContactInfo);
                dbContext.SaveChanges();
                TempData["SuccessMessage"] = $"Thank you, {ContactInfo.Name}. We will be in touch shortly.";
                Save = true;
                //return Page();
                return RedirectToPage("Contact");
                
            }
            else {
                return Page();
            }

        }
    }
}
