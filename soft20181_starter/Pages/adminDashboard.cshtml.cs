using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using soft20181_starter.Models;

namespace soft20181_starter.Pages
{
    [Authorize(Roles = "Admin")]
    public class adminDashboardModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly EventAppDbContext _dbContext;
       
        public adminDashboardModel(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager,
            EventAppDbContext dbContext)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _dbContext = dbContext;

        }
        public List<IdentityRole> roles { get; set; }
        public List<AppUser> users { get; set; }

        public List<Contact> contact {  get; set; }

        [BindProperty (SupportsGet =true)]
        public string Id {  get; set; }

        [BindProperty]
		public string roleName { get; set; }

		[BindProperty]
		public string Password { get; set; }

		
        public async Task<IActionResult>OnGetAsync()
        {
            roles = await _roleManager.Roles.ToListAsync();
            users = await _userManager.Users.ToListAsync();
            contact = await _dbContext.Contacts.ToListAsync();
            return Page();
        }

        public async Task<IActionResult> OnGetDeleteAsync()
        {
            var role = await _roleManager.FindByIdAsync(Id);
            if (role != null)
            {
                // Delete the role if it exists
                var result = await _roleManager.DeleteAsync(role);
            }
            else
            {
                var user = await _userManager.FindByIdAsync(Id);
				if (user != null)
				{
					// Delete the user if it exists
					var result = await _userManager.DeleteAsync(user);
				}
				
            }
			return RedirectToPage();

        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _roleManager.CreateAsync(new IdentityRole(roleName.Trim()));
            return RedirectToPage("/adminDashboard");
        }

        public async Task<IActionResult> OnPostUpdateAsync()
        {
            var users = await _userManager.FindByIdAsync(Id);
            await _userManager.RemovePasswordAsync(users);
            await _userManager.AddPasswordAsync(users, Password);
            return RedirectToPage("/adminDashboard");
        }

	}
}
