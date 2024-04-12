import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { PriceCalculatorComponent } from './features/vehicle_price_calculator/price-calculator/price-calculator.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, PriceCalculatorComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})

export class AppComponent {
  title = 'VehiclePriceCalculator';
}
