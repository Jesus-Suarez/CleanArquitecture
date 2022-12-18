using CleanArquitecture.Presenters;
using CleanArquitecture.RepositoryEFCore;
using CleanArquitecture.UseCases;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArquitecture.InversionOfControl
{
	public static class DependencyContainer
	{
		/// <summary>
		/// Hacemos Inversion de Control
		/// </summary>
		/// <param name="services"></param>
		/// <param name="configuration"></param>
		/// <returns>services</returns>
		public static IServiceCollection AddCleanArquitectureDependencies(
			this IServiceCollection services,
			IConfiguration configuration)
		{
			services.AddRepositories(configuration);
			services.AddUseCasesServices();
			services.AddPresenters();

			return services;
		}
	}
}