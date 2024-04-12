import { Routes } from '@angular/router';
import { PriceCalculatorComponent } from './features/vehicle_price_calculator/price-calculator/price-calculator.component';

export const routes: Routes = [
    {
        path: '',
        component: PriceCalculatorComponent
    }
];

export class AppRoutingModule { }