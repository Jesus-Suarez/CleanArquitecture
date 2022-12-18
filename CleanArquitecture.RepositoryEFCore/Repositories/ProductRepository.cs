using CleanArquitecture.Entities.Interfaces;
using CleanArquitecture.Entities.POCOs;
using CleanArquitecture.RepositoryEFCore.DataContext;

namespace CleanArquitecture.RepositoryEFCore.Repositories
{
	public class ProductRepository : IProductRepository
	{
		readonly CleanArquitectureContext Context;

		/// <summary>
		/// Ctor de la clase
		/// </summary>
		public ProductRepository(CleanArquitectureContext context)
		{
			Context = context;
		}

		public IEnumerable<Product> GetAll()
		{
			return Context.Products;
		}

		public void CreateProduct(Product product)
		{
			Context.Add(product);
		}
	}
}
