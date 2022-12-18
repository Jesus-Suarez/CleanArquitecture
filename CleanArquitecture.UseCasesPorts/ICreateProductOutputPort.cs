using CleanArquitecture.DTOs;

namespace CleanArquitecture.UseCasesPorts
{
	public interface ICreateProductOutputPort
	{
		Task Handle(ProductDTO productDTO);
	}
}
