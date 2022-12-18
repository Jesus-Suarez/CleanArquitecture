
using CleanArquitecture.DTOs;
using CleanArquitecture.Entities.Interfaces;
using CleanArquitecture.Entities.POCOs;
using CleanArquitecture.UseCasesPorts;
using System;
using System.Linq;

namespace CleanArquitecture.UseCases.GetAllProducts
{
	public class GetAllProductsInteractor : IGetAllProductsInputPort
	{
		private readonly IProductRepository iProductRepository;
		readonly IGetAllProductsOutputPort iGetAllProductsOutputPort;

		/// <summary>
		/// Constructor de la clase, con inyeccion de dependencias
		/// </summary>
		public GetAllProductsInteractor(IProductRepository repository, IGetAllProductsOutputPort outputPort)
			=> (iProductRepository, iGetAllProductsOutputPort)
			= (repository, outputPort);

		/// <summary>
		/// implementacion de las interface
		/// </summary>
		/// <returns></returns>
		public Task Handle()
		{

			//Nota: el Select es un automapper
			var Products = iProductRepository.GetAll().Select(p =>
			{
				return new ProductDTO()
				{
					Id = p.Id,
					Name = p.Name
				};
			});

			iGetAllProductsOutputPort.Handle(Products);

			return Task.CompletedTask;
		}
	}
}
