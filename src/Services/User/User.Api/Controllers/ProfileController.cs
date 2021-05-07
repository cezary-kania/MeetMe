using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace User.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfileController : ControllerBase
    {
        [HttpGet("{userId}")]
        public async Task<IActionResult> GetBasicProfileInfoAsync([FromRoute]Guid userId)
        {
            // Temporary Mock
            var profile = await Task.FromResult(new {UserId = userId, FirstName = "Jan", Lastname = "Malinowski"});
            return Ok(profile);
        }
    }
}