using FirstApi.Models;
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
		public async Task<ActionResult> Create(FirstModel firstModel)
		{
			await service.Create(firstModel);
			return Ok();
		}
	}
};