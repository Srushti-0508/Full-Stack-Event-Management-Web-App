using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using soft20181_starter.Models;

namespace soft20181_starter.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        // Events on the Home Page
        private readonly EventAppDbContext dbContext;
        public List<TheEvent> Events { get; set; }
        public IndexModel(ILogger<IndexModel> logger, EventAppDbContext _db)
        {
            _logger = logger;
            dbContext = _db;

        }
       
        
  
        
        public void OnGet()
        {
            Events = dbContext.Events.ToList();
        }
    }
}
