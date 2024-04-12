using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehiclePriceCalculator.API.DTO;
using VehiclePriceCalculator.API.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VehiclePriceCalculator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclePriceCalculatorController : ControllerBase
    {

        private readonly IVehiclePriceCalculatorService _service;

        public VehiclePriceCalculatorController(IVehiclePriceCalculatorService service)
        {
            _service = service;
        }

        [HttpPost]
        public OkObjectResult CalculatePrices(VehiclePriceCalculatorRequestDto request)
        {
            System.Diagnostics.Debug.WriteLine(request);

            var response = new VehiclePriceCalculatorResponseDto
            {
                GrossBasePrice = (request.GrossBasePrice != 0) ? request.GrossBasePrice : Math.Round(_service.CalculateGrossBasePrice(request.NetBasePrice, request.VatRate), 2),
                NetBasePrice = (request.NetBasePrice != 0) ? request.NetBasePrice : Math.Round(_service.CalculateNetBasePrice(request.GrossBasePrice, request.VatRate), 2),
                GrossEquipmentPrice = (request.GrossEquipmentPrice != 0) ? request.GrossEquipmentPrice : Math.Round(_service.CalculateGrossEquipmentPrice(request.NetEquipmentPrice, request.VatRate), 2),
                NetEquipmentPrice = (request.NetEquipmentPrice != 0) ? request.NetEquipmentPrice : Math.Round(_service.CalculateNetEquipmentPrice(request.GrossEquipmentPrice, request.VatRate), 2)
            };

            response.NetTotalPrice = Math.Round(_service.CalculateNetTotalPrice(response.NetBasePrice, response.NetEquipmentPrice), 2);
            response.GrossTotalPrice = Math.Round(_service.CalculateNetTotalPrice(response.GrossBasePrice, response.GrossEquipmentPrice), 2);

            return Ok(response);
        }
    }
}
