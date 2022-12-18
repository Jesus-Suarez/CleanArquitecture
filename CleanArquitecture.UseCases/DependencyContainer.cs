using CleanArquitecture.UseCases.CreateProduct;
using CleanArquitecture.UseCases.GetAllProducts;
using CleanArquitecture.UseCasesPorts;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArquitecture.UseCases
{
	public static class DependencyContainer
	{
		public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
		{
			//Interpretacion: Yo implemento el servicio ICreateProductInputPort y lo hago atravez de CreateProductInteractor
			services.AddTransient<ICreateProductInputPort, CreateProductInteractor>();
			services.AddTransient<IGetAllProductsInputPort, GetAllProductsInteractor>();

			return services;
		}
	}
}
