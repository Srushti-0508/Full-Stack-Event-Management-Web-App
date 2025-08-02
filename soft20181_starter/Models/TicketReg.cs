using Microsoft.AspNetCore.Identity;
namespace soft20181_starter.Models

{
	public class TicketReg
	{
		public int ID { get; set; }
		public int UserID {  get; set; }

		public int EventID {  get; set; }

		public AppUser User { get; set; }

		public TheEvent Event { get; set; }
	}
}
