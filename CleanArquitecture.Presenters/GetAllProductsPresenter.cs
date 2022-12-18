using CleanArquitecture.DTOs;
using CleanArquitecture.UseCasesPorts;

namespace CleanArquitecture.Presenters
{
	public class GetAllProductsPresenter : IGetAllProductsOutputPort, IPresenter<IEnumerable<ProductDTO>>
	{
		/// <summary>
		/// implementacion de la interface generica IPresenter
		/// </summary>
		public IEnumerable<ProductDTO> Content { get; private set; }

		public Task Handle(IEnumerable<ProductDTO> products)
		{
			Content = products;

			return Task.CompletedTask;
		}
	}
}
