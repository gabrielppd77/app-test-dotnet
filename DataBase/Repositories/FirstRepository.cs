using FirstApi.Models;

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
	}
}