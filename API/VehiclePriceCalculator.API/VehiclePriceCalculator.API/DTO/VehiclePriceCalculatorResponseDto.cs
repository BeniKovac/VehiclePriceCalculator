namespace VehiclePriceCalculator.API.DTO
{
    public class VehiclePriceCalculatorResponseDto
    {
        public decimal NetBasePrice { get; set; }

        public decimal NetEquipmentPrice { get; set; }

        public decimal GrossBasePrice { get; set; }

        public decimal GrossEquipmentPrice { get; set; }

        public decimal NetTotalPrice { get; set; }

        public decimal GrossTotalPrice { get; set; }
    }
}
