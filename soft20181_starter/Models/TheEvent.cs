namespace soft20181_starter.Models
{
    public class TheEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime EventDateTime { get; set; }
        public string CoverPhoto { get; set; }
        public int noOfAtn {  get; set; }

        //new image columns
        public string EventImg {  get; set; }

		public ICollection<TicketReg> TicketReg { get; set; }
	}
}
