using CleanArquitecture.DTOs;
using CleanArquitecture.Presenters;
using CleanArquitecture.UseCasesPorts;
using Microsoft.AspNetCore.Mvc;

namespace CleanArquitecture.Controllers
{
	[ApiController] // para que swagger vea el method
	[Route("api/v1/[controller]")]
	public class GetAllProductsController
	{
		private readonly IGetAllProductsInputPort iGetAllProductsInputPort;
		private readonly IGetAllProductsOutputPort iGetAllProductsOutputPort;

		/// <summary>
		/// Contructor con BodyExpressions, al que se le inyecta
		/// </summary>
		/// <param name="iGetAllProductsInputPort"></param>
		/// <param name="iGetAllProductsOutputPort"></param>
		public GetAllProductsController(IGetAllProductsInputPort iGetAllProductsInputPort, IGetAllProductsOutputPort iGetAllProductsOutputPort)
			=> (this.iGetAllProductsInputPort, this.iGetAllProductsOutputPort)
			= (iGetAllProductsInputPort, iGetAllProductsOutputPort);

		[HttpGet]
		public async Task<List<ProductDTO>> GetAllProducts()
		{
			await iGetAllProductsInputPort.Handle();

			//  return ((IPresenter<List<ProductDTO>>)iGetAllProductsOutputPort).Content; en lineas separadas
			IPresenter<List<ProductDTO>> presenter = (IPresenter<List<ProductDTO>>)iGetAllProductsOutputPort;
			return presenter.Content;
		}
	}
}
