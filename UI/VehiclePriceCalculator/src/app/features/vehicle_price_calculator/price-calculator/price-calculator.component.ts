import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { VehiclePriceCalculatorService } from '../services/vehicle-price-calculator.service';

@Component({
  selector: 'price-calculator',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './price-calculator.component.html',
  styleUrl: './price-calculator.component.css'
})
export class PriceCalculatorComponent {
  netBaseDisabled = false;
  grossBaseDisabled = true;
  netEquipmentDisabled = false;
  grossEquipmentDisabled = true;
  selectedOptionBase = 'net_base_price_radio';
  selectedOptionEquipment = 'net_equipment_price_radio';
  netBasePrice = 0;
  grossBasePrice = 0;
  netEquipmentPrice = 0;
  grossEquipmentPrice = 0;
  netTotalPrice = 0;
  grossTotalPrice = 0;
  vatRate = 0.22;

  constructor(private vehiclePriceCalculatorSerivice: VehiclePriceCalculatorService) {}

  public disableOppositeBaseInput(){
      this.netBaseDisabled = this.selectedOptionBase != 'net_base_price_radio';
      this.grossBaseDisabled = this.selectedOptionBase == 'net_base_price_radio';
  }

  public disableOppositeEquipmentInput(){
      this.netEquipmentDisabled = this.selectedOptionEquipment != 'net_equipment_price_radio';
      this.grossEquipmentDisabled = this.selectedOptionEquipment == 'net_equipment_price_radio';
  }

  public submitVehiclePriceCalculatorForm(){
    this.vehiclePriceCalculatorSerivice.sendPricesToApi({
      netBasePrice: (this.netBaseDisabled) ? 0 : this.netBasePrice,
      netEquipmentPrice: (this.netEquipmentDisabled) ? 0 : this.netEquipmentPrice,
      grossBasePrice: (this.grossBaseDisabled) ? 0 : this.grossBasePrice,
      grossEquipmentPrice: (this.grossEquipmentDisabled) ? 0 : this.grossEquipmentPrice,
      netTotalPrice: this.netTotalPrice,
      grossTotalPrice: this.grossTotalPrice,
      VatRate: this.vatRate,
    })
    .subscribe({
      next: (response) => {
        this.netBasePrice = response.netBasePrice;
        this.grossBasePrice = response.grossBasePrice;
        this.netEquipmentPrice = response.netEquipmentPrice;
        this.grossEquipmentPrice = response.grossEquipmentPrice;
        this.netTotalPrice = response.netTotalPrice;
        this.grossTotalPrice = response.grossTotalPrice;
      },
      error: (error) => {
        console.log('There was an error with fetching data.');
      }
    });
  }
}