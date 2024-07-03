using LogisticApp.DTOs;
using LogisticApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LogisticApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;
        
        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            var result = await _authService.RegisterAsync(request);
            if (!result.Success) return BadRequest(result.Message);
            return Ok(result);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            var result = await (_authService.LoginAsync(request));
            if (!result.Success) return BadRequest(result.Message);
            return Ok(new  { Token = result.Token });
        }
    }
}