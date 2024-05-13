using FirstApi.DataBase.Repositories;
using FirstApi.DTOs;
using FirstApi.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace FirstApi.Services
{
	public class FirstService
	{
		private readonly FirstRepository repository;

		public FirstService(FirstRepository repository)
		{
			this.repository = repository;
		}

		public async Task Create(FirstDTO first)
		{
			var anyNameExists = await repository.AnyNameExists(first.name);

			if (anyNameExists)
			{
				throw new Exception("Not FOund");
			}

			var newFirtModel = new FirstModel(first.name, first.password);
			await repository.Create(newFirtModel);
			await repository.SaveChanges();
		}

		internal async Task<List<FirstDTO>> GetAll()
		{
			var models = await repository.GetAll();
			return models.Select(x => new FirstDTO(x.Name, x.Password)).ToList();
		}
	}
}