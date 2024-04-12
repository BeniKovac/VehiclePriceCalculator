namespace VehiclePriceCalculator.API.DTO
{
    public class VehiclePriceCalculatorRequestDto
    {
        public decimal NetBasePrice { get; set; }

        public decimal NetEquipmentPrice { get; set; }

        public decimal GrossBasePrice { get; set; }

        public decimal GrossEquipmentPrice { get; set; }

        public decimal VatRate { get; set; }
    }
}
