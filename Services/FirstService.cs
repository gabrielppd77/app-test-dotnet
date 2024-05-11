using FirstApi.DataBase.Repositories;
using FirstApi.Models;

namespace FirstApi.Services
{
	public class FirstService
	{
		private readonly FirstRepository repository;

		public FirstService(FirstRepository repository)
		{
			this.repository = repository;
		}

		public async Task Create(FirstModel firstModel)
		{
			await repository.Create(firstModel);
			await repository.SaveChanges();
		}
	}
}