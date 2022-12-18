using CleanArquitecture.DTOs;

namespace CleanArquitecture.UseCasesPorts
{
	public interface IGetAllProductsOutputPort
	{
		Task Handle(IEnumerable<ProductDTO> products);
	}
}
