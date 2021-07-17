using Microsoft.EntityFrameworkCore;
using System;

namespace DataLayer
{
	public class ImageSaverContext: DbContext
	{
		public DbSet<Image> Images { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=DESKTOP-MBD1D44;Database=ImageSaver;Trusted_Connection=True;");
		}
	}
}
