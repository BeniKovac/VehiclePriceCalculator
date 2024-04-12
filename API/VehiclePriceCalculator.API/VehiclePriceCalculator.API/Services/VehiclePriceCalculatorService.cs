namespace VehiclePriceCalculator.API.Services
{
    public interface IVehiclePriceCalculatorService
    {
        decimal CalculateNetBasePrice(decimal GrossBasePrice, decimal VatRate);
        decimal CalculateNetEquipmentPrice(decimal GrossEquipmentPrice, decimal VatRate);
        decimal CalculateNetTotalPrice(decimal NetBasePrice, decimal NetEquipmentPrice);
        decimal CalculateGrossBasePrice(decimal NetBasePrice, decimal VatRate);
        decimal CalculateGrossEquipmentPrice(decimal NetEquipmentPrice, decimal VatRate);
        decimal CalculateGrossTotalPrice(decimal GrossBasePrice, decimal GrossEquipmentPrice);
    }

    public class VehiclePriceCalculatorService : IVehiclePriceCalculatorService
    {
        public decimal CalculateGrossBasePrice(decimal NetBasePrice, decimal VatRate)
        {
            return NetBasePrice * (1 + VatRate);
        }

        public decimal CalculateGrossEquipmentPrice(decimal NetEquipmentPrice, decimal VatRate)
        {
            return NetEquipmentPrice * (1 + VatRate);
        }

        public decimal CalculateGrossTotalPrice(decimal GrossBasePrice, decimal GrossEquipmentPrice)
        {
            return GrossBasePrice + GrossEquipmentPrice;
        }

        public decimal CalculateNetBasePrice(decimal GrossBasePrice, decimal VatRate)
        {
            return GrossBasePrice / (1 + VatRate);
        }

        public decimal CalculateNetEquipmentPrice(decimal GrossEquipmentPrice, decimal VatRate)
        {
            return GrossEquipmentPrice / (1 + VatRate);
        }

        public decimal CalculateNetTotalPrice(decimal NetBasePrice, decimal NetEquipmentPrice)
        {
            return NetBasePrice + NetEquipmentPrice;
        }
    }
}
