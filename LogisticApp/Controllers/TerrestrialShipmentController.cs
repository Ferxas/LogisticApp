using LogisticApp.DTOs;
using LogisticApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace LogisticApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerrestrialShipmentsController : ControllerBase
    {
        private readonly ShipmentService _shipmentService;

        public TerrestrialShipmentsController(ShipmentService shipmentService)
        {
            _shipmentService = shipmentService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTerrestrialShipment(TerrestrialShipmentsController request)
        {
            var result = await _shipmentService.CreateTerrestrialShipment(request);
            if (!result.Success) return BadRequest(result.Message);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetTerrestrialShipments()
        {
            var result = await _shipmentService.GetTerrestrialShipmentsAsync();
            return Ok(result);
        }
    }
}