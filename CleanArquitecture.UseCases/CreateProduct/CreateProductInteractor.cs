using CleanArquitecture.DTOs;
using CleanArquitecture.Entities.Interfaces;
using CleanArquitecture.Entities.POCOs;
using CleanArquitecture.UseCasesPorts;

namespace CleanArquitecture.UseCases.CreateProduct
{
	// Se programa para Abstracciones(interfaces) no Implementaciones
	/// <summary>
	/// Interactor que resolvera el caso de uso
	/// </summary>
	public class CreateProductInteractor : ICreateProductInputPort
	{
		readonly IProductRepository iProductRepository;
		readonly IUnitOfWork iUnitOfWork;
		readonly ICreateProductOutputPort iCreateProductOutputPort;

		/// <summary>
		/// CTOR de la clase que implementa; por Dependency Injection
		/// </summary>
		/// <param name="iProductRepository"></param>
		/// <param name="iUnitOfWork"></param>
		/// <param name="iCreateProductOutputPort"></param>
		public CreateProductInteractor(
			IProductRepository iProductRepository,
			IUnitOfWork iUnitOfWork,
			ICreateProductOutputPort iCreateProductOutputPort
			)
		{
			this.iProductRepository = iProductRepository;
			this.iCreateProductOutputPort = iCreateProductOutputPort;
			this.iUnitOfWork = iUnitOfWork;
		}

		//otra forma de hacer el mismo contructor es 

		/*public CreateProductInteractor(IProductRepository iProductRepository,
			IUnitOfWork iUnitOfWork,
			ICreateProductOutputPort iCreateProductOutputPort) => (this.iProductRepository, this.iUnitOfWork, this.iCreateProductOutputPort)
			=
			(iProductRepository,
			iUnitOfWork,
			iCreateProductOutputPort);*/

		/// <summary>
		/// Implementa la logica de negocios
		/// </summary>
		/// <param name="createProductDTO"></param>
		/// <returns></returns>
		public async Task Handle(CreateProductDTO createProductDTO)
		{
			Product newProduct = new Product()
			{
				Name = createProductDTO.ProductName
			};

			iProductRepository.CreateProduct(newProduct);

			await iUnitOfWork.SaveChanges();

			// Se crea el DTO para devolverlo
			await iCreateProductOutputPort.Handle(
				new ProductDTO()
				{
					Id = newProduct.Id,
					Name = newProduct.Name
				});
		}
	}
}
