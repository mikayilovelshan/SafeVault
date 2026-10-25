using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SafeVault.Models;

namespace SafeVault.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost("validate")]
        public IActionResult ValidateUser(RegisterRequest request)
        {
            return Ok(new
            {
                Message = "Input validation successful",
                request.Username,
                request.Email
            });
        }
    }
}
