using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FirstController : ControllerBase
    {
        [HttpPost()]
        public async ActionResult Create()
        {
            return Ok();
        }
    }
};