using LogisticApp.DTOs;
using LogisticApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LogisticApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarineShipmentsController : ControllerBase
    {
        private readonly ShipmentService _shipmentService;

        public MarineShipmentsController(ShipmentService shipmentService)
        {
            _shipmentService = shipmentService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateMarineShipment(MarineShipmentRequest request)
        {
            var result = await _shipmentService.CreateMarineShipment(request);
            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetMarineShipments()
        {
            var result = await _shipmentService.GetMarineShipmentsAsync();
            return Ok(result);
        }
    }
}