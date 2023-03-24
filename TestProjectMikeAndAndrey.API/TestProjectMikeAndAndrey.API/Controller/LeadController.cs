using Microsoft.AspNetCore.Mvc;
using TestProjectMikeAndAndrey.Logic.Models;

namespace TestProjectMikeAndAndrey.API.Controller
{
    [Route("lead")]
    [ApiController]
    public class LeadController : ControllerBase
    {
        [HttpPost("add-user")]
        public IActionResult PostLead([FromBody] LeadRequestModel model)
        {
            Console.WriteLine($"{model.LastName} {model.FirstName} {model.TelefonNumber}");
            return Ok();
        }
    }
}
