using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MovieStoreMvc.Models.Domain

{
	public class DataBaseContext : IdentityDbContext<ApplicationUser>
	{
        public DataBaseContext (DbContextOptions<DataBaseContext > options) : base(options)
        {
             
        }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<MovieGenre> MovieGenre { get; set; }
        public DbSet<Movie> Movie { get; set; }

    }
}
