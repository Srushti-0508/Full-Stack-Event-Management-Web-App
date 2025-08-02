using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.DotNet.Scaffolding.Shared.Project;



using Microsoft.EntityFrameworkCore;

namespace soft20181_starter.Models
{
    public class EventAppDbContext : IdentityDbContext<AppUser>
    {
        public EventAppDbContext(DbContextOptions<EventAppDbContext> options) : base(options)
        {}
        public DbSet<TheEvent> Events { get; set; }
        public DbSet<Contact> Contacts { get; set; }

  //      public DbSet<TicketReg> TicketReg { get; set; }


		//protected override void OnModelCreating(ModelBuilder modelbuilder)
		//{

		//	modelbuilder.Entity<TicketReg>()
  //              .HasKey(r=> r.ID);

  //          modelbuilder.Entity<TicketReg>()
  //              .HasOne(r => r.User)
  //          .WithMany(u => u.TicketReg)
  //          .IsRequired();

		//	modelbuilder.Entity<TicketReg>()
		//		.HasOne(r => r.Event)
		//	.WithMany(e => e.TicketReg)
		//	.IsRequired();


		//}
	}

}
