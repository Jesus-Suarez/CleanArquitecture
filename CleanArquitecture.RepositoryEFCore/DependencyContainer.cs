using CleanArquitecture.Entities.Interfaces;
using CleanArquitecture.RepositoryEFCore.DataContext;
using CleanArquitecture.RepositoryEFCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArquitecture.RepositoryEFCore
{
	/// <summary>
	/// Contenedor de dependencias para no saturar el StartUp
	/// </summary>
	public static class DependencyContainer
	{
		/// <summary>
		/// Metodo para registrar las dependencias
		/// </summary>
		/// <param name="services"></param>
		/// <param name="configuration"></param>
		/// <returns></returns>
		public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<CleanArquitectureContext>(options => options.UseSqlServer(configuration.GetConnectionString("CleanArquitecture")));
			services.AddScoped<IProductRepository, ProductRepository>();
			services.AddScoped<IUnitOfWork, UnitOfWork>();

			return services;
		}
	}
}
