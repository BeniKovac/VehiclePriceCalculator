export interface PricesCalculatorApiRequest {
    netBasePrice: number;
    netEquipmentPrice: number;
    grossBasePrice: number;
    grossEquipmentPrice: number;
    netTotalPrice: number;
    grossTotalPrice: number;
    VatRate: number;
}
