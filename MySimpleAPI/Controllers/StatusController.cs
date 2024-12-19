using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MySimpleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {

        [HttpGet("GetStatus")]
        public async Task<IActionResult> GetStatus()
        {
            // adding testing comment
            return Ok();
        }
    }
}
