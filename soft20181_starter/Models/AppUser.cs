using Microsoft.AspNetCore.Identity;
namespace soft20181_starter.Models
{
    public class AppUser:IdentityUser
    {
        //public ICollection<TicketReg> TicketReg { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
    }
}
