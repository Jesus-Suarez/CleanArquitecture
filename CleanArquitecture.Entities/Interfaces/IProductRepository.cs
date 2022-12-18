
using CleanArquitecture.Entities.POCOs;

namespace CleanArquitecture.Entities.Interfaces
{
	public interface IProductRepository
	{
		void CreateProduct(Product product);
		IEnumerable<Product> GetAll();
	}
}
