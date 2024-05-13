using FirstApi.DTOs;
using FirstApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class FirstController : ControllerBase
	{
		private readonly FirstService service;

		public FirstController(FirstService service)
		{
			this.service = service;
		}

		[HttpPost()]
		public async Task Create(FirstDTO firstModel)
		{
			await service.Create(firstModel);
		}

		[HttpGet()]
		public async Task<List<FirstDTO>> GetAll()
		{
			return await service.GetAll();
		}
	}
};