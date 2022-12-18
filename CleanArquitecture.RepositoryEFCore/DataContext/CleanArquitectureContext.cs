using CleanArquitecture.Entities.POCOs;
using Microsoft.EntityFrameworkCore;

namespace CleanArquitecture.RepositoryEFCore.DataContext
{
	public class CleanArquitectureContext : DbContext
	{
		/// <summary>
		/// CTOR for the context
		/// </summary>
		/// <param name="options"></param>
		public CleanArquitectureContext(DbContextOptions<CleanArquitectureContext> options) : base(options) { }

		public DbSet<Product> Products { get; set; }
	}
}
