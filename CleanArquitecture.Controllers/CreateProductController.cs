using CleanArquitecture.DTOs;
using CleanArquitecture.Presenters;
using CleanArquitecture.UseCasesPorts;
using Microsoft.AspNetCore.Mvc;

namespace CleanArquitecture.Controllers
{
	[Route("api/v1/[controller]")]
	[ApiController] // para que swagger vea el method
	public class CreateProductController
	{
		private readonly ICreateProductInputPort iCreateProductInputPort;
		private readonly ICreateProductOutputPort iCreateProductOutputPort;

		public CreateProductController(ICreateProductInputPort iCreateProductInputPort, ICreateProductOutputPort iCreateProductOutputPort)
		{
			this.iCreateProductInputPort = iCreateProductInputPort;
			this.iCreateProductOutputPort = iCreateProductOutputPort;
		}

		[HttpPost]
		public async Task<ProductDTO> CreateProduct(CreateProductDTO product)
		{
			await iCreateProductInputPort.Handle(product);

			// Se hace casteo de iCreateProductOutputPort.Content antes de retornar
			return ((IPresenter<ProductDTO>)iCreateProductOutputPort).Content;
		}
	}
}
