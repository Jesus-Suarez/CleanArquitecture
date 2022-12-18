
namespace CleanArquitecture.Entities.Interfaces
{
	public interface IUnitOfWork
	{
		Task<int> SaveChanges();
	}
}
