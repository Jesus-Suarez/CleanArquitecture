using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CleanArquitecture.RepositoryEFCore.DataContext
{
	public class CleanArquitectureContextFactory : IDesignTimeDbContextFactory<CleanArquitectureContext>
	{
		/// <summary>
		/// CTOR de la fabrica para las migraciones de EF core
		/// </summary>
		/// <param name="args"></param>
		/// <returns>CleanArquitectureContext</returns>
		public CleanArquitectureContext CreateDbContext(string[] args)
		{
			var OptionsBuilder = new DbContextOptionsBuilder<CleanArquitectureContext>();
			OptionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;database=CleanArquitecture");

			return new CleanArquitectureContext(OptionsBuilder.Options);
		}
	}
}
