using CleanArquitecture.UseCasesPorts;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArquitecture.Presenters
{
	public static class DependencyContainer
	{
		public static IServiceCollection AddPresenters(this IServiceCollection services)
		{
			services.AddScoped<ICreateProductOutputPort, CreateProductPresenter>();
			services.AddScoped<IGetAllProductsOutputPort, GetAllProductsPresenter>();

			return services;
		}
	}
}
