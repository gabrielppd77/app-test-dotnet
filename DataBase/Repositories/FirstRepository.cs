using FirstApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstApi.DataBase.Repositories
{
	public class FirstRepository
	{
		private readonly PgContext context;

		public FirstRepository(PgContext context)
		{
			this.context = context;
		}

		public async Task Create(FirstModel firstModel)
		{
			await context.FirstModel.AddAsync(firstModel);
		}

		public async Task SaveChanges()
		{
			await context.SaveChangesAsync();
		}

		public async Task<bool> AnyNameExists(string name)
		{
			return await context.FirstModel
				.Where(x => x.Name == name)
				.AnyAsync();
		}

		internal async Task<List<FirstModel>> GetAll()
		{
			return await context.FirstModel.ToListAsync();
		}
	}
}