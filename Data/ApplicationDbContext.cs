using Microsoft.EntityFrameworkCore;
using RunHub.Models;

namespace RunHub.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
		public DbSet<Race> Races { get; set; }
		public DbSet<Club> Clubs { get; set; }
		public DbSet<Address> Addresses { get; set; }
		public DbSet<State> States { get; set; }
		public DbSet<City> Cities { get; set; }
	}
}