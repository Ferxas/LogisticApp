using LogisticApp.Models;
using LogisticApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace LogisticApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ClientsController : ControllerBase
    {
        private readonly ClientService _clientService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateClient(Client client)
    {
        var result = await _clientService.CreateClientAsync(client);
        if (!result.Sucess) return BadRequest(result.Message);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetClients()
    {
        var result = await _clientService.GetClientsAsync();
        return Ok(result);
    }
}
