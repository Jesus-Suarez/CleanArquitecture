using CleanArquitecture.Entities.Interfaces;
using CleanArquitecture.RepositoryEFCore.DataContext;

namespace CleanArquitecture.RepositoryEFCore.Repositories
{
	public class UnitOfWork : IUnitOfWork
	{
		readonly CleanArquitectureContext Context;

		/// <summary>
		/// CTOR de las clase, le inyectamos el Contexto
		/// </summary>
		public UnitOfWork(CleanArquitectureContext context)
		{
			this.Context = context;
		}

		public Task<int> SaveChanges()
		{
			return Context.SaveChangesAsync();
		}
	}
}
