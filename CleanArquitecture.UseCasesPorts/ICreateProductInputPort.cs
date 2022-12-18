using CleanArquitecture.DTOs;

namespace CleanArquitecture.UseCasesPorts
{
	public interface ICreateProductInputPort
	{
		Task Handle(CreateProductDTO createProductDTO);
	}
}
